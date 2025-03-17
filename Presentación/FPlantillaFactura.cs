using CAD;
using Negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace Presentación
{
    public partial class FPlantillaFactura : Form
    {
        private bool facturaCreada = false;
        int id;
        int tipo;
        private DataRowView facturaTemp;

        public FPlantillaFactura(int _id, int _tipo)
        {
            InitializeComponent();
            id = _id;
            tipo = _tipo;

            if (tipo == 0) // FACTURA NUEVA
            {
                bsFacturas.AddNew();
                NClientes.mostrarClientes(dsGimnasio1);
                NProductos.obtenerProductos(dsGimnasio1);
                activarDesglose(false);
            }
            else // FACTURA EXISTENTE 
            {
                CargarFacturaExistente(id);
                activarDesglose(true);
            }
        }

        private void FNuevaFactura_Load(object sender, EventArgs e)
        {
            dtpEmision.Value = DateTime.Today;
            dtpVencimiento.Value = dtpEmision.Value.AddMonths(1);
            dtpFechaPago.Value = dtpEmision.Value; // POR DEFECTO = MISMO DÍA DE CREAR FACTURA  
            NClientes.mostrarClientes(dsGimnasio1);
            NProductos.obtenerProductos(dsGimnasio1);
            cmbClientes.SelectedIndex = -1;
            cmbProductos.SelectedIndex = -1;
            LimpiarCamposCliente();
            ConfigurarColumnasDataGridView();
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedIndex != -1 && !facturaCreada)
            {
                facturaTemp = (DataRowView)bsFacturas.Current;

                // Rellenamos toda la cabecera de la factura

                if (facturaTemp != null)
                {
                    facturaTemp["FechaEmision"] = DateTime.Today;
                    facturaTemp["FechaVencimiento"] = DateTime.Today.AddMonths(1);

                    // Envio por defecto de momento
                    facturaTemp["IdEnvio"] = 1;
                    facturaTemp["FechaEnvio"] = DateTime.Today;
                    facturaTemp["FechaPago"] = DateTime.Today;
                    facturaTemp["IdTipoPago"] = 1; // Efectivo

                    // Asegurarse de que SelectedValue sea válido y no sea null
                    if (cmbClientes.SelectedValue != null && !string.IsNullOrEmpty(cmbClientes.SelectedValue.ToString()))
                    {
                        facturaTemp["Id_Cliente"] = cmbClientes.SelectedValue;
                    }
                    else
                    {
                        facturaTemp["Id_Cliente"] = 0;  // ID por defecto si no se selecciona un cliente
                    }
                    facturaTemp["IdEstadoFactura"] = 2;
                }
            }
        }




        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!facturaCreada || cmbProductos.SelectedIndex == -1 || string.IsNullOrEmpty(txtCantidad.Text)) return;

            bsDesglose.AddNew();
            var desgloseActual = ((DataRowView)bsDesglose.Current).Row;
            desgloseActual["IdFactura"] = ((DataRowView)bsFacturas.Current)[0];
            desgloseActual["IdProducto"] = cmbProductos.SelectedValue;
            desgloseActual["Cantidad"] = Convert.ToInt32(txtCantidad.Text);
            desgloseActual["BaseImponible"] = Convert.ToDecimal(txtBaseImponible.Text);
            desgloseActual["Concepto"] = txtConcepto.Text;
            desgloseActual["IdTipoIVA"] = 1;
            bsDesglose.EndEdit();

            NFactura.actualizarDesgloses(dsGimnasio1);
            MessageBox.Show("Desglose añadido a la factura : " + ((DataRowView)bsFacturas.Current)[0], "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgProductos.Rows.Add(cmbProductos.Text, txtCantidad.Text, txtBaseImponible.Text, "21%");

            // Limpiar campos   
            limpiarDesglose();
        }

        private void limpiarDesglose()
        {
            txtCantidad.Clear();
            txtBaseImponible.Text = "-";
            txtCodigo.Text = "-";
            txtPVP.Text = "-";
            txtConcepto.Clear();
            cmbProductos.SelectedIndex = -1;
        }

        private void btnEliminarDesglose_Click(object sender, EventArgs e)
        {
            if (dgProductos.SelectedRows.Count > 0)
            {
                int index = dgProductos.SelectedRows[0].Index;
                bsDesglose.RemoveAt(index);
                dgProductos.Rows.RemoveAt(index);
            }
        }

        /// <summary>
        /// Cargar factura existente
        /// Aplicamos desbloqueo de campos y cargamos el desglose de la factura.
        /// </summary>
        /// <param name="facturaId"></param>
        private void CargarFacturaExistente(int facturaId) 
        {
            NFactura.obtenerFacturaId(dsGimnasio1, facturaId);
            if (bsFacturas.Count > 0)
            {
                facturaCreada = true;
                activarDesglose(true);
                NFactura.obtenerDesgloseFactura(dsGimnasio1, facturaId);
                CargarDesgloseEnGrid();
            }
        }

        private void CargarDesgloseEnGrid()
        {
            dgProductos.Rows.Clear();
            foreach (DataRow row in dsGimnasio1.FacturaDesglose.Rows)
            {
                dgProductos.Rows.Add(row["NombreProducto"], row["Cantidad"], row["BaseImponible"], "21%");
            }
        }

        private void ConfigurarColumnasDataGridView()
        {
            dgProductos.Columns.Clear();
            dgProductos.Columns.Add("Producto", "Producto");
            dgProductos.Columns.Add("Cantidad", "Cantidad");
            dgProductos.Columns.Add("Precio", "Precio");
            dgProductos.Columns.Add("IVA", "IVA");
        }

        private void LimpiarCamposCliente()
        {
            txtApellidos.Clear();
            txtDNI.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtUsuario.Clear();
            txtPVP.Text = "-";
            txtCodigo.Text = "-";
            txtBaseImponible.Text = "-";
        }

        public bool activarDesglose(bool estado)
        {
            btnAgregar.Enabled = estado;
            btnEliminar.Enabled = estado;
            cmbProductos.Enabled = estado;
            txtCantidad.Enabled = estado;
            txtConcepto.Enabled = estado;
            return estado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(facturaTemp != null)
            {
                bsFacturas.EndEdit();
                facturaTemp = null;
                facturaCreada = true;

                NFactura.actualizarFacturas(dsGimnasio1);

                activarDesglose(true);

            }
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

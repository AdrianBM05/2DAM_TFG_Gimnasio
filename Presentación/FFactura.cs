using CAD.DSGimnasioTableAdapters;
using Negocio;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System;

namespace Presentación
{
    public partial class FFactura : Form
    {
        private FGestionFacturas _gestionFacturas;
        private int _id;
        private int _tipo;
        private bool facturaCreada = false;

        public FFactura(int id, int tipo, FGestionFacturas gestionFacturas)
        {
            InitializeComponent();
            _id = id;
            _tipo = tipo;
            _gestionFacturas = gestionFacturas; // Guardar la referencia
        }

        private void FFactura_Load(object sender, EventArgs e)
        {
            modificarDatosCliente(); // Desactivar campos de cliente
            ToggleDesglose(); // Activación/desactivación del desglose

            if (_tipo == 0) // Factura nueva
            {
                CargarDatosNuevaFactura();
            }
            else if (_tipo == 1) // Factura existente
            {
                CargarDatosFacturaExistente();
            }
        }

        private void CargarDatosNuevaFactura()
        {
            bsFacturas.AddNew();
            NClientes.mostrarClientes(dsGimnasio1);
            NProductos.obtenerProductos(dsGimnasio1);
            NFactura.obtenerEstadoFactura(dsGimnasio1);
            NFactura.obtenerTipoPago(dsGimnasio1);
            NFactura.obtenerEnvio(dsGimnasio1);

            // Editar campos por defecto
            cmbClientes.SelectedIndex = -1;
            modificarDatosCliente(); // Limpiar campos de cliente
            cbEstadoFactura.SelectedIndex = 1; // 0 == Pagada / 1 == Pendiente 

            // Modificar fechas por defecto
            DateTime hoy = DateTime.Today;
            dtpEmision.Value = hoy;
            dtpVencimiento.Value = hoy.AddMonths(1);
            dtpFechaPago.Value = hoy;
            dtpEnvio.Value = hoy;
        }

        private void CargarDatosFacturaExistente()
        {
            
        }

        private void cargarDesgloses()
        {
            

        }

        private void modificarDatosCliente()
        {
            txtApellidos.Clear();
            txtDNI.Clear();
            txtCorreo.Clear();
        }

        private void ToggleDesglose()
        {
            tlpDesgloses.Enabled = !tlpDesgloses.Enabled;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _gestionFacturas.contenedor.Controls.Clear();
            _gestionFacturas.contenedor.Controls.Add(_gestionFacturas.dataGridView1);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Comprobamos los campos en una misma condicion
            if (cmbClientes.SelectedIndex == -1 || cbEstadoFactura.SelectedIndex == -1 || cmbTipoPago.SelectedIndex == -1 || cbEnvio.SelectedIndex == -1)
            {
                MessageBox.Show("Rellene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear nueva factura ( id autoincremnt )
            DataRowView facturaTemp = (DataRowView)bsFacturas.Current;
            facturaTemp["FechaEmision"] = dtpEmision.Value; // Asignar un valor predeterminado inmediatamente
            // Continuar con otras asignaciones
            facturaTemp["Id_Cliente"] = cmbClientes.SelectedValue;
            facturaTemp["FechaVencimiento"] = dtpVencimiento.Value;
            facturaTemp["IdEstadoFactura"] = cbEstadoFactura.SelectedIndex;
            facturaTemp["IdEnvio"] = cbEnvio.SelectedIndex;
            facturaTemp["FechaEnvio"] = dtpEnvio.Value;
            facturaTemp["FechaPago"] = dtpFechaPago.Value;
            facturaTemp["IdTipoPago"] = cmbTipoPago.SelectedIndex;

            // Guardar cambios
            bsFacturas.EndEdit();
            NFactura.actualizarFacturas(dsGimnasio1);

            // Recargar los datos de la factura para obtener el Id actualizado
            bsFacturas.ResetBindings(false);
            facturaTemp = (DataRowView)bsFacturas.Current;

            // Guardamos el id para los desgloses
            int idFactura = (int)facturaTemp["Id"];

            // Activamos desglose y desactivamos factura
            ToggleDesglose();
            facturaCreada = true;
            // Mostrar id factura para probar
            MessageBox.Show("Factura creada con id : " + idFactura, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnGuardarDesglose_Click(object sender, EventArgs e)
        {

            // Cargamos el id de la factura
            DataRowView facturaTemp = (DataRowView)bsFacturas.Current;
            int idFactura = (int)facturaTemp["Id"];

            // Comprobamos que los campos no estén vacíos
            if (!facturaCreada || cmbProductos.SelectedIndex == -1 || string.IsNullOrEmpty(txtCantidad.Text)) return;

            bsDesglose.AddNew();
            DataRowView desgloseTemp = (DataRowView)bsDesglose.Current;
            desgloseTemp["IdFactura"] = idFactura;
            desgloseTemp["IdProducto"] = cmbProductos.SelectedValue;
            desgloseTemp["Cantidad"] = Convert.ToInt32(txtCantidad.Text);
            desgloseTemp["BaseImponible"] = Convert.ToDecimal(txtBImponible.Text);
            desgloseTemp["IdTipoIVA"] = 1;
            desgloseTemp["Concepto"] = txtConcepto.Text;
            bsDesglose.EndEdit();

            NFactura.actualizarDesgloses(dsGimnasio1);

            // MOstramos mensaje de confirmación
            MessageBox.Show("Desglose añadido a la factura : " + idFactura, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // MOstrar id del desglose (probar que se crea en la bd)
            MessageBox.Show("Desglose añadido con id : " + ((DataRowView)bsDesglose.Current)[0], "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void limpiarDesglose()
        {
            txtCantidad.Clear();
            txtBImponible.Text = "-";
            txtCodigo.Text = "-";
            txtConcepto.Clear();
            cmbProductos.SelectedIndex = -1;
        }
    }
}

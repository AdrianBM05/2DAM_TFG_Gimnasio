using CAD.DSGimnasioTableAdapters;
using Negocio;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System;
using System.Drawing;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Collections.Generic;
using Font = System.Drawing.Font;
using Microsoft.Reporting.WinForms;

namespace Presentación
{
    public partial class FFactura : Form
    {
        private FGestionFacturas _gestionFacturas;
        private int _id;
        private int _tipo;
        private bool facturaCreada = false;

        // Variables para el total de la factura
        private decimal totalFactura = 0;
        private int totalProductos = 0; // Numero de productos (* Cantidad)
        private decimal totalBaseImponible = 0;
        private decimal totalCoste = 0;


        public FFactura(int id, int tipo, FGestionFacturas gestionFacturas)
        {
            InitializeComponent();
            _id = id;
            _tipo = tipo;
            _gestionFacturas = gestionFacturas; // Guardar la referencia
        }

        private void FFactura_Load(object sender, EventArgs e)
        {
            // propiedadesDGV();
            modificarDatosCliente(); // Desactivar campos de cliente
            ToggleDesglose(); // Activación/desactivación del desglose
            LoadStyle(); // Cargar el estilo del DataGridView

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
            
            if(cbEstadoFactura.Items.Count > 0) cbEstadoFactura.SelectedIndex = 1; // Por defecto en estado pendiente

            // Modificar fechas por defecto
            DateTime hoy = DateTime.Today;
            dtpEmision.Value = hoy;
            dtpVencimiento.Value = hoy.AddMonths(1);
            dtpFechaPago.Value = hoy;
            dtpEnvio.Value = hoy;
        }

        private void CargarDatosFacturaExistente()
        {

            facturaCreada = true; // Activar desglose

            // Cargar listas en los ComboBox
            NClientes.mostrarClientes(dsGimnasio1);
            NProductos.obtenerProductos(dsGimnasio1);
            NFactura.obtenerEstadoFactura(dsGimnasio1);
            NFactura.obtenerTipoPago(dsGimnasio1);
            NFactura.obtenerEnvio(dsGimnasio1);
            NVFacturas.obtenerFacturasByBusqueda(dsGimnasio1, _id);  // Método para filtrar y obtener la factura en el dataset
            NVDesglose.obtenerDesglosesByIdFactura(dsGimnasio1, _id); // Obtener los desgloses de una factura

            // Desactivar desgloses: Primero modificar o no datos de la factura
            ToggleDesglose();
            // Buscar la factura en la base de datos
            NFactura.obtenerFacturaId(dsGimnasio1, _id);  // Método para filtrar y obtener la factura en el dataset
            if (bsFacturas.Count == 0)
            {
                MessageBox.Show("No se encontró la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Establecer la factura en el BindingSource
            bsFacturas.Position = 0; // Asegurar que se apunta a la primera (y única) fila cargada
            DataRowView facturaTemp = (DataRowView)bsFacturas.Current;

            // Asignar valores a los controles con comprobaciones de null y tipos correctos
            cmbClientes.SelectedValue = facturaTemp["Id_Cliente"] != DBNull.Value ? facturaTemp["Id_Cliente"] : -1;
            dtpEmision.Value = facturaTemp["FechaEmision"] != DBNull.Value ? Convert.ToDateTime(facturaTemp["FechaEmision"]) : DateTime.Now;
            dtpVencimiento.Value = facturaTemp["FechaVencimiento"] != DBNull.Value ? Convert.ToDateTime(facturaTemp["FechaVencimiento"]) : DateTime.Now;
            cbEstadoFactura.SelectedValue = facturaTemp["IdEstadoFactura"] != DBNull.Value ? Convert.ToInt32(facturaTemp["IdEstadoFactura"]) : -1;
            cbEnvio.SelectedValue = facturaTemp["IdEnvio"] != DBNull.Value ? Convert.ToInt32(facturaTemp["IdEnvio"]) : -1;
            dtpEnvio.Value = facturaTemp["FechaEnvio"] != DBNull.Value ? Convert.ToDateTime(facturaTemp["FechaEnvio"]) : DateTime.Now;
            dtpFechaPago.Value = facturaTemp["FechaPago"] != DBNull.Value ? Convert.ToDateTime(facturaTemp["FechaPago"]) : DateTime.Now;
            cmbTipoPago.SelectedValue = facturaTemp["IdTipoPago"] != DBNull.Value ? facturaTemp["IdTipoPago"] : -1;

            // Cargar los desgloses de la factura
            cargarDesgloses();
        }


        private void cargarDesgloses()
        {
            // Obtener los desgloses de una factura
            NVDesglose.obtenerDesglosesByIdFactura(dsGimnasio1, _id);
            cargarTotalFactura();

        }

        private void modificarDatosCliente()
        {
            txtApellidos.Clear();
            txtDNI.Clear();
            txtCorreo.Clear();
        }
        
        private void LoadStyle()
        {
            // Estilo del DataGridView -> Celda Cambria Normal 10, Cabecera Cambria Negrita 10
            dgvDesglose.DefaultCellStyle.Font = new Font("Cambria", 9);
            dgvDesglose.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 9, FontStyle.Bold);
        }

        private void ToggleDesglose()
        {
            tlpDatosDesglose.Enabled = !tlpDatosDesglose.Enabled;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _gestionFacturas.contenedor.Controls.Clear();
            _gestionFacturas.contenedor.Controls.Add(_gestionFacturas.dataGridView1);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Explicación de código:
            // ABRIR Factura = Factura YA creada que puede ser modificada todos los campos
            // CREAR Factura = Factura nueva que se crea con los campos necesarios y se guarda en la base de datos

            // El botón de guardar se comporta de dos maneras:
            // 1. Crear una nueva factura
            // 2. Guardar los cambios de una factura existente
            // La condición facturaCreada se encarga de diferenciar entre ambas situaciones

            if (facturaCreada)
            {

                // En esta condición: Guardar los cambios de una factura existente - NO craer una nueva
                if (cmbClientes.SelectedIndex == -1 || cbEstadoFactura.SelectedIndex == -1 || cmbTipoPago.SelectedIndex == -1 || cbEnvio.SelectedIndex == -1)
                {
                    MessageBox.Show("Rellene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // GUardar todos los campos (Datosde cliente, envio, fechas, etc)
                txtApellidos.Text = txtApellidos.Text;
                txtCorreo.Text = txtCorreo.Text;
                txtDNI.Text = txtDNI.Text;
                dtpEmision.Value = dtpEmision.Value;
                dtpVencimiento.Value = dtpVencimiento.Value;
                dtpEnvio.Value = dtpEnvio.Value;
                dtpFechaPago.Value = dtpFechaPago.Value;
                cmbTipoPago.SelectedValue = (int)cmbTipoPago.SelectedValue;
                cbEnvio.SelectedValue = (int)cbEnvio.SelectedValue;
                cbEstadoFactura.SelectedValue = (int)cbEstadoFactura.SelectedValue;

                bsFacturas.EndEdit();
                NFactura.actualizarFacturas(dsGimnasio1);
                MessageBox.Show("Factura actualizada con id : " + _id, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Activamos el desglose para que se puedan añadir más productos
                ToggleDesglose();

                
            }
            else
            {
                // Si no esta creada cargamos una nueva
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


        }


        private void btnGuardarDesglose_Click(object sender, EventArgs e)
        {
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

            // Mensaje de confirmación
            MessageBox.Show("Desglose añadido a la factura con id : " + idFactura, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            NFactura.actualizarFacturas(dsGimnasio1);
            NFactura.actualizarDesgloses(dsGimnasio1);

            cargarDesgloses();
            cargarTotalFactura();
        }


        private void cargarTotalFactura()
        {
            // Campos de cero
            totalFactura = 0;
            totalCoste = 0;
            totalBaseImponible = 0;
            totalProductos = 0;

            // Por cada fila en el DataGridView: Sumar el total de la factura
            foreach (DataGridViewRow row in dgvDesglose.Rows)
            {
                totalFactura += Convert.ToDecimal(row.Cells[6].Value) * Convert.ToInt32(row.Cells[8].Value);
                totalCoste += Convert.ToDecimal(row.Cells[3].Value) * Convert.ToInt32(row.Cells[8].Value);
                totalBaseImponible += Convert.ToDecimal(row.Cells[4].Value) * Convert.ToInt32(row.Cells[8].Value);
                totalProductos += Convert.ToInt32(row.Cells[8].Value);
            }

            // Mostrar los resultados en los campos correspondientes
            lblTotalFactura.Text = totalFactura.ToString();
            lblTotalCoste.Text = totalCoste.ToString();
            lblTotalBImponible.Text = totalBaseImponible.ToString();
            lblTotalProductos.Text = totalProductos.ToString();

        }

        private void btnEliminarDesglose_Click(object sender, EventArgs e)
        {
            // Eliminar el desglose seleccionado en el datagridview con una confirmación
            if (dgvDesglose.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar el desglose seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Eliminar el desglose seleccionado
                    int idDesglose = Convert.ToInt32(dgvDesglose.SelectedRows[0].Cells[0].Value);
                    NVDesglose.eliminarDesglose(dsGimnasio1, idDesglose);
                    cargarDesgloses();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un desglose para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tlpDesgloses_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnEditarDesglose_Click(object sender, EventArgs e)
        {
            // Modificar el desglose seleccionado en el DataGridView
            if (dgvDesglose.SelectedRows.Count > 0)
            {
                // Comprobar que los campos no estén vacíos
                if (cmbProductos.SelectedIndex == -1 || string.IsNullOrEmpty(txtCantidad.Text)) return;
                // Modificar el desglose seleccionado
                int idDesglose = Convert.ToInt32(dgvDesglose.SelectedRows[0].Cells[0].Value);
                DataRowView desgloseTemp = (DataRowView)bsDesglose.Current;
                desgloseTemp["IdProducto"] = cmbProductos.SelectedValue;
                desgloseTemp["Cantidad"] = Convert.ToInt32(txtCantidad.Text);
                desgloseTemp["BaseImponible"] = Convert.ToDecimal(txtBImponible.Text);
                desgloseTemp["IdTipoIVA"] = 1;
                desgloseTemp["Concepto"] = txtConcepto.Text;
                bsDesglose.EndEdit();
                // Mensaje para pruebas
                MessageBox.Show("Desglose modificado con id : " + idDesglose, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NFactura.actualizarFacturas(dsGimnasio1);
                NFactura.actualizarDesgloses(dsGimnasio1);
                cargarDesgloses();
            }
            else
            {
                MessageBox.Show("Seleccione un desglose para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDesglose_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Seleccionar el desglose en el DataGridView
            if (e.RowIndex >= 0)
            {
                dgvDesglose.Rows[e.RowIndex].Selected = true;

                // bUSCAR EL desgloses mediante su id
                int idDesglose = Convert.ToInt32(dgvDesglose.Rows[e.RowIndex].Cells[0].Value);
                NFactura.obtenerDesgloseById(dsGimnasio1, idDesglose);

                // Asignar los valores a los controles
                DataRowView desgloseTemp = (DataRowView)bsDesglose.Current;


                // Asignamos los valores a los controles
                cmbProductos.SelectedValue = desgloseTemp["IdProducto"];
                txtCantidad.Text = desgloseTemp["Cantidad"].ToString();
                txtBImponible.Text = desgloseTemp["BaseImponible"].ToString();
                txtConcepto.Text = desgloseTemp["Concepto"].ToString();
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // Abrir mostrar factura pasando el idFactura y el idCliente
            FMostrarFactura mostrarFactura = new FMostrarFactura(_id, (int)cmbClientes.SelectedValue);
            mostrarFactura.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            btnGenerar_Click(sender, e);
        }
    }
}

using Negocio;
using System;
using System.Data;
using System.Windows.Forms;

using Negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace Presentación
{
    public partial class FFactura : Form
    {
        private readonly FGestionFacturas _gestionFacturas;
        private readonly int _id;
        private readonly int _tipo;
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
            // TODO: Implementar lógica para cargar factura existente
        }

        // Función para limpiar campos de cliente
        private void modificarDatosCliente()
        {
            txtApellidos.Clear();
            txtDNI.Clear();
            txtCorreo.Clear();
        }

        /// <summary>
        /// Activa o desactiva el diseño del desglose.
        /// </summary>
        private void ToggleDesglose()
        {
            tlpDesgloses.Enabled = !tlpDesgloses.Enabled;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            // Volver a mostrar el DataGridView
            _gestionFacturas.contenedor.Controls.Clear();
            _gestionFacturas.contenedor.Controls.Add(_gestionFacturas.dataGridView1);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ToggleDesglose(); // Activamos el desglose

            // TODO: Implementar lógica de guardado
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedIndex == -1 || facturaCreada) return;

            // Verificar que el binding source tiene un elemento seleccionado
            if (bsFacturas.Current is DataRowView facturaTemp)
            {
                // Rellenamos la cabecera de la factura
                facturaTemp["FechaEmision"] = DateTime.Today;
                facturaTemp["FechaVencimiento"] = DateTime.Today.AddMonths(1);

                // Envío por defecto
                facturaTemp["IdEnvio"] = 1;
                facturaTemp["FechaEnvio"] = DateTime.Today;
                facturaTemp["FechaPago"] = DateTime.Today;
                facturaTemp["IdTipoPago"] = 1; // Efectivo

                // Validar y asignar ID del cliente
                if (cmbClientes.SelectedValue != null && int.TryParse(cmbClientes.SelectedValue.ToString(), out int idCliente))
                {
                    facturaTemp["Id_Cliente"] = idCliente;
                }
                else
                {
                    facturaTemp["Id_Cliente"] = DBNull.Value;  // Dejarlo como nulo en la base de datos
                }

                facturaTemp["IdEstadoFactura"] = 2;
            }
        }
    }
}

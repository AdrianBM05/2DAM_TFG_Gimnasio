using CAD.DSGimnasioTableAdapters;
using Negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace Presentación
{
    public partial class FFichaCliente : Form
    {
        private int id;
        private DateTime fechaInicio;

        public FFichaCliente(int _id, int tipo, DateTime _fechaInicio)
        {
            InitializeComponent();
            this.CenterToScreen();
            NTarifas.obtenerTarifas(dsGimnasio1);
            NEstados.obtenerEstados(dsGimnasio1);
            fechaInicio = _fechaInicio;

            if (tipo == 0)
            {
                bsClientes.AddNew();
                ((DataRowView)bsClientes.Current).Row["Fecha_Inicio_Tarifa"] = fechaInicio;
                ((DataRowView)bsClientes.Current).Row["IdTipo_Cuenta"] = 1;
                ((DataRowView)bsClientes.Current).Row["Id_Estado"] = 1;
            }
            else if (tipo == 1)
            {
                id = _id;
                NClientes.obtenerClienteID(dsGimnasio1, id);
            }
        }

        private void FClienteFicha2_Load(object sender, EventArgs e) { }
        private void FClienteFicha2_Load_1(object sender, EventArgs e) { }
        private void nameTextBox_TextChanged(object sender, EventArgs e) { }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void bsClientes_CurrentChanged(object sender, EventArgs e) { }
        private void btnFactura_Click(object sender, EventArgs e) { }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == 0)
                {
                    ((DataRowView)bsClientes.Current).Row["Nombre"] = txtNombre.Text;
                    ((DataRowView)bsClientes.Current).Row["Apellidos"] = txtApellidos.Text;
                    ((DataRowView)bsClientes.Current).Row["DNI"] = txtDNI.Text;
                    ((DataRowView)bsClientes.Current).Row["Dirección"] = txtDireccion.Text;
                    ((DataRowView)bsClientes.Current).Row["Usuario"] = txtUsuario.Text;
                    ((DataRowView)bsClientes.Current).Row["Contraseña"] = txtContraseña.Text;
                    ((DataRowView)bsClientes.Current).Row["Correo"] = txtCorreo.Text;
                }

                int idTarifa = comboBoxTarifas.SelectedIndex + 1;
                ((DataRowView)bsClientes.Current).Row["IdTarifa"] = idTarifa;

                DateTime fechaCaducidad = fechaInicio;
                switch (idTarifa)
                {
                    case 1:
                        fechaCaducidad = fechaInicio.AddMonths(1);
                        break;
                    case 2:
                        fechaCaducidad = fechaInicio.AddMonths(3);
                        break;
                    case 3:
                        fechaCaducidad = fechaInicio.AddMonths(1);
                        break;
                    case 4:
                        fechaCaducidad = fechaInicio.AddYears(1);
                        break;
                }

                ((DataRowView)bsClientes.Current).Row["Fecha_Caducidad_Tarifa"] = fechaCaducidad;

                bsClientes.EndEdit();
                NVClientes.actualizarClientes(dsGimnasio1);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

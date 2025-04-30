using CAD.DSGimnasioTableAdapters;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            // 0 = NUEVO // 1 = MODIFICAR
            if (tipo == 0)
            {
                //txtFechaInicio.Text = fechaInicio.ToString();
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }

        private void nameTextBox_TextChanged(object sender, EventArgs e) { }
        private void FClienteFicha2_Load_1(object sender, EventArgs e) { }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            try
            {

                // Cuando el cliente es nuevo, hay que guardar el resto de campos necesarios
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

                if (comboBoxTarifas.SelectedIndex == 0)
                { 
                    ((DataRowView)bsClientes.Current).Row["IdTarifa"] = 1;
                    ((DataRowView)bsClientes.Current).Row["Fecha_Caducidad_Tarifa"] = fechaInicio.AddMonths(1);
                }

                if (comboBoxTarifas.SelectedIndex == 1)
                {
                    ((DataRowView)bsClientes.Current).Row["IdTarifa"] = 2;
                    ((DataRowView)bsClientes.Current).Row["Fecha_Caducidad_Tarifa"] = fechaInicio.AddMonths(3);
                }

                if (comboBoxTarifas.SelectedIndex == 2) // Mensual + Servicio.
                {
                    ((DataRowView)bsClientes.Current).Row["IdTarifa"] = 3;
                    ((DataRowView)bsClientes.Current).Row["Fecha_Caducidad_Tarifa"] = fechaInicio.AddMonths(1);
                }

                if (comboBoxTarifas.SelectedIndex == 3)
                {
                    ((DataRowView)bsClientes.Current).Row["IdTarifa"] = 4;
                    ((DataRowView)bsClientes.Current).Row["Fecha_Caducidad_Tarifa"] = fechaInicio.AddYears(1);
                }

                bsClientes.EndEdit();
                NVClientes.actualizarClientes(dsGimnasio1);
                Close();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        private void bsClientes_CurrentChanged(object sender, EventArgs e) { }
        private void btnFactura_Click(object sender, EventArgs e) { }
    }
}

using CAD;
using CAD.Instancias;
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
    public partial class FLogin : Form
    {

        // Para instanciar usuario
        public Cliente _cliente;
        public Empleado _empleado;

        public FLogin()
        {
            InitializeComponent();
            this.CenterToScreen();

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
                    }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        // Botón bueno
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty((txtUsuario.Text).ToLower()) && !String.IsNullOrEmpty((txtContraseña.Text).ToLower()))
            {
                // Obtener empleado por el usuario ingresado - Lower Case
                NEmpleado.obtenerEmpleado(dsGimnasio1, txtUsuario.Text);

                if (bsEmpleados.Count == 1)
                {
                    // Comprobar la contraseña del empleado - Lower Case
                    if (((DataRowView)bsEmpleados.Current).Row["Contraseña"].ToString().ToLower() != (txtContraseña.Text).ToLower())
                    {
                        MessageBox.Show("La clave es incorrecta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Comprobar el estado del empleado
                    if ((int)((DataRowView)bsEmpleados.Current).Row["Id_Estado"] == 2)
                    {
                        MessageBox.Show("Este usuario está dado de baja.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Instanciar el objeto empleado con los datos obtenidos
                    _empleado = new Empleado(
                        (int)((DataRowView)bsEmpleados.Current).Row["Id"],
                        ((DataRowView)bsEmpleados.Current).Row["Nombre"].ToString(),
                        ((DataRowView)bsEmpleados.Current).Row["Apellidos"].ToString(),
                        ((DataRowView)bsEmpleados.Current).Row["DNI"].ToString(),
                        ((DataRowView)bsEmpleados.Current).Row["Dirección"].ToString(),
                        ((DataRowView)bsEmpleados.Current).Row["Usuario"].ToString(),
                        ((DataRowView)bsEmpleados.Current).Row["Contraseña"].ToString(),
                        ((DataRowView)bsEmpleados.Current).Row["Correo"].ToString(),
                        (int)((DataRowView)bsEmpleados.Current).Row["IdTipo_Cuenta"],
                        (int)((DataRowView)bsEmpleados.Current).Row["Id_Estado"]
                    );

                    // Ocultar el formulario de login y abrir la ventana principal de empleados
                    Hide();
                    FPrincipal ventana = new FPrincipal(_empleado);
                    ventana.ShowDialog();
                    Close(); // Cerrar el formulario de login
                }
                else
                {
                    MessageBox.Show("El usuario no existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Faltan datos por introducir.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                    }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        
    }
}

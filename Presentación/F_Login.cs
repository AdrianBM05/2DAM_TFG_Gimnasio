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
    public partial class F_Login : Form
    {

        // Para instanciar usuario
        public Cliente _cliente;
        public Empleado _empleado;

        public F_Login()
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
        private void button1_Click_2(object sender, EventArgs e)
        {

            if((!String.IsNullOrEmpty(txtUsuario.Text)) && (!String.IsNullOrEmpty(txtContraseña.Text)))
            {

                if (rbtnCliente.Checked && !rbtnEmpleado.Checked)
                {

                    NClientes.obtenerClientes(dsGimnasio1,txtUsuario.Text);

                    if(bsClientes.Count == 1)
                    {

                        // Comprobar contraseña del cliente
                        if (((DataRowView)bsClientes.Current).Row["Contraseña"].ToString() != txtContraseña.Text)
                        {
                            MessageBox.Show("La clave es incorrecta.","ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        // Comprobar el estado del cliente
                        if ((int)((DataRowView)bsClientes.Current).Row["Id_Estado"] == 2)
                        {
                            MessageBox.Show("Este cliente está dado de baja.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Instancio el cliente con los valores de su fila
                        _cliente = new Cliente((int)((DataRowView)bsClientes.Current).Row["Id"], ((DataRowView)bsClientes.Current).Row["Nombre"].ToString(), ((DataRowView)bsClientes.Current).Row["Apellidos"].ToString(), ((DataRowView)bsClientes.Current).Row["DNI"].ToString(), ((DataRowView)bsClientes.Current).Row["Dirección"].ToString().ToString(), (int)((DataRowView)bsClientes.Current).Row["IdTarifa"], ((DataRowView)bsClientes.Current).Row["Usuario"].ToString().ToString(), ((DataRowView)bsClientes.Current).Row["Contraseña"].ToString(), ((DataRowView)bsClientes.Current).Row["Correo"].ToString().ToString(), (int)((DataRowView)bsClientes.Current).Row["IdTipo_Cuenta"], (int)((DataRowView)bsClientes.Current).Row["Id_Estado"]);
                        Hide();

                        // Abro la ventana principal para ese usuario
                        MessageBox.Show("Cliente ha iniciado sesión.");

                    }

                } // Cliente check

                // Ahora lo mismo para un empleado (tiene otra interfaz)

                if(rbtnEmpleado.Checked && !rbtnCliente.Checked)
                {
                    
                    NEmpleado.obtenerEmpleado(dsGimnasio1,txtUsuario.Text);

                    if (bsEmpleados.Count == 1)
                    {

                        if (((DataRowView)bsEmpleados.Current).Row["Contraseña"].ToString() != txtContraseña.Text)
                        {
                            MessageBox.Show("La clave es incorrecta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if ((int)((DataRowView)bsEmpleados.Current).Row["Id_Estado"] == 2)
                        {
                            MessageBox.Show("Este usuario está dado de baja.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        _empleado = new Empleado((int)((DataRowView)bsEmpleados.Current).Row["Id"], ((DataRowView)bsEmpleados.Current).Row["Nombre"].ToString(), ((DataRowView)bsEmpleados.Current).Row["Apellidos"].ToString(), ((DataRowView)bsEmpleados.Current).Row["DNI"].ToString(), ((DataRowView)bsEmpleados.Current).Row["Dirección"].ToString(), ((DataRowView)bsEmpleados.Current).Row["Usuario"].ToString(), ((DataRowView)bsEmpleados.Current).Row["Contraseña"].ToString(), ((DataRowView)bsEmpleados.Current).Row["Correo"].ToString(), (int)((DataRowView)bsEmpleados.Current).Row["IdTipo_Cuenta"], (int)((DataRowView)bsEmpleados.Current).Row["Id_Estado"]);
                        Hide();

                        FPrincipalEmpleado ventana = new FPrincipalEmpleado(_empleado);
                        ventana.ShowDialog();
                        Close(); // Cerrar actual

                    }


                }




            } else
            {
                MessageBox.Show("Faltan datos por introducir.", "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
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

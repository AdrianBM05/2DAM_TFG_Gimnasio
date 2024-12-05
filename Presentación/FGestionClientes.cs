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
    public partial class FGestionClientes : Form
    {
        public Empleado _empleado;
        public FGestionClientes(Empleado _Empleado)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            _empleado = _Empleado;
            FPrincipalEmpleado._gestionClientes = this;


            lblUsuario.Text = "Bienvenido: " + _empleado.Nombre + _empleado.Apellido;

            /* Comprobar estado de la tabla clientes
            NClientes.actualizarEstadoCliente(dsGimnasio1);
            NClientes.mostrarClientes(dsGimnasio1);
            */

            // Muestra de clientes mediante una vista
            NVClientes.actualizarClientes(dsGimnasio1);
            NVClientes.obtenerClientes(dsGimnasio1);
            NVClientes.obtenerEstado(dsGimnasio1);

        }

        private void FGestionClientes_Load(object sender, EventArgs e)
        {

        }

        private void FGestionClientes_Leave(object sender, EventArgs e)
        {
            
        }

        private void FGestionClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            FPrincipalEmpleado._gestionClientes = null;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {

            // Ajustar fecha actual de ese momento 
            DateTime actual = DateTime.Now;

            FClienteFicha2 ficha = new FClienteFicha2(0,0,actual);
            ficha.Show();

            NVClientes.obtenerClientes(dsGimnasio1);


        }

        private void btnFicha_Click(object sender, EventArgs e)
        {

            // Abrir ficha del cliente
            if(bsVClientes.Count > 0)
            {
                FClienteFicha2 ficha = new FClienteFicha2((int)((DataRowView)bsVClientes.Current).Row["Id"],1, (DateTime)((DataRowView)bsVClientes.Current).Row["Fecha_Inicio_Tarifa"]);
                ficha.Show();

                NVClientes.obtenerClientes(dsGimnasio1);

            }

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string textoBuscar = txtBusqueda.Text;

            NVClientes.mostrarBusqueda(dsGimnasio1,textoBuscar);


        }

        private void btnIngresosMensuales_Click(object sender, EventArgs e)
        {

            double ingresos = NTarifas.calcularIngresosMensuales(dsGimnasio1);

            MessageBox.Show("Ingresos por clientes este mes: " + ingresos+ "€.", "Ingresos mensuales", MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            // Comprobar ficha caducada

            try
            {
                // Sacar el estado
                string estado = (((DataRowView)bsVClientes.Current).Row["Estado"].ToString());


            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            NVClientes.obtenerEstado(dsGimnasio1);
            NVClientes.actualizarClientes(dsGimnasio1);
            NVClientes.obtenerClientes(dsGimnasio1);
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {

            try
            {
                // CLiente seleccionado
                int id = (int)(((DataRowView)bsVClientes.Current).Row["Id"]);

                if (id > 0)
                {

                    // Sacar el estado
                    string estado = (((DataRowView)bsVClientes.Current).Row["Estado"].ToString());

                    if (estado == "Activo")
                    {

                        // Preguntar
                        DialogResult rest = MessageBox.Show("¿Desea dar de baja al cliente?", "Información", MessageBoxButtons.YesNo, icon: MessageBoxIcon.Information);
                        if (rest == DialogResult.Yes)
                        {
                            NClientes.cambiarEstadoCliente(id,2);
                        }


                    }
                    else if ( estado == "Desactivo")
                    {

                        // Preguntar
                        DialogResult rest = MessageBox.Show("¿Desea dar de alta al cliente?", "Información", MessageBoxButtons.YesNo, icon: MessageBoxIcon.Information);
                        if (rest == DialogResult.Yes)
                        {
                            NClientes.cambiarEstadoCliente(id, 1);
                        }


                    }

                }

            } catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }
    }
}

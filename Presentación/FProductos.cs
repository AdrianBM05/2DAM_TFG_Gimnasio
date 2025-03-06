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
    public partial class FProductos : Form
    {

        public Empleado _empleado;

        public FProductos(Empleado empleado)
        {
            InitializeComponent();
            _empleado = empleado;
            this.WindowState = FormWindowState.Maximized;
            FPrincipalEmpleado._productos = this;

            lblUsuario.Text = "Bienvenido: " + _empleado.Nombre + _empleado.Apellido;

            NVProductos.obtenerProductos(dsGimnasio1);

            llenarSecciones();


        }

        private void FProductos_Load(object sender, EventArgs e)
        {

        }

        // Llenar secciones para filtros
        public void llenarSecciones()
        {

            comboBoxSecciones.Items.Clear();
            comboBoxSecciones.Items.Add("Todos");
            NSysSeccion.llenarSecciones(dsGimnasio1);
            bsSecciones.MoveFirst();
            for (int i = 0; i < bsSecciones.Count; i++)
            {
                comboBoxSecciones.Items.Add(((DataRowView)bsSecciones.Current).Row["Sección"].ToString());
                bsSecciones.MoveNext();
            }

        }

        private void bsProductos_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSecciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSecciones.Text == "Todos")
            {
                bsProductos.RemoveFilter(); // Quitar el filtro para mostrar todos los productos
            }
            else
            {
                bsProductos.Filter = "Sección='" + comboBoxSecciones.Text + "'";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FProductoFicha ficha = new FProductoFicha(0,0);
            ficha.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NVProductos.actualizarProductos(dsGimnasio1);
            NVProductos.obtenerProductos(dsGimnasio1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if(bsProductos.Count > 0)
            {
                FProductoFicha ficha = new FProductoFicha((int)((DataRowView)bsProductos.Current).Row["Id"], 1);
                ficha.ShowDialog();
            }


        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

            string busqueda = txtBusqueda.Text;

            NProductos.mostrarBusqueda(dsGimnasio1, busqueda);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

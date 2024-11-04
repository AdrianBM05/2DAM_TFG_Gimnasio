using CAD.Instancias;
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
    public partial class FPrincipalEmpleado : Form
    {

        
        public Empleado _empleado;
        public static FPrincipalEmpleado _fPrincipalEmpleado;
        public static FGestionClientes _gestionClientes;
        public static FProductos _productos;
        

        public FPrincipalEmpleado(Empleado _Empleado)
        {
            // Inicio con el empleado que se ha logueado

            InitializeComponent();
            _fPrincipalEmpleado = this;
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            _empleado = _Empleado;

            // Por defecto pag gestion de clientes

            _gestionClientes = new FGestionClientes(_empleado);
            _gestionClientes.MdiParent = this;
            _gestionClientes.Show();

        }

        private void FPrincipalEmpleado_Load(object sender, EventArgs e)
        {

        }

        

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (_gestionClientes == null)
            {
                _gestionClientes = new FGestionClientes(_empleado);
                _gestionClientes.MdiParent = this;
                _gestionClientes.Show();

            }else
            {
                _gestionClientes.BringToFront();
            }


        }

        private void menuStripEmpleado_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FProductos productos = new FProductos(_empleado);

            if (_productos != null)
            {
                _productos = productos;
                _productos.MdiParent = this;
                _productos.Show();
            }
            else
            {
               /// _productos.Show();
                _productos.BringToFront();
            }


        }
    }
}

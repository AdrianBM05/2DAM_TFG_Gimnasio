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
    public partial class FPrincipal : Form
    {

        
        public Empleado _empleado;
        public static FPrincipal _fPrincipalEmpleado;
        public static FGestionClientes _gestionClientes;
        public static FGestionProductos _productos;
        public static FGestionFacturas _gestionFacturas;
        public static FPanelControl _panelControl;


        public FPrincipal(Empleado _Empleado)
        {
            // Inicio con el empleado que se ha logueado

            InitializeComponent();
            _fPrincipalEmpleado = this;
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            _empleado = _Empleado;

            // Defecto : Panel de control
            _panelControl = new FPanelControl(_empleado);
            _panelControl.MdiParent = this;
            _panelControl.Show();

            

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

            FGestionProductos productos = new FGestionProductos(_empleado);

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

        private void ribbon1_Click(object sender, EventArgs e)
        {

        }

        private void facturasTSM_Click(object sender, EventArgs e)
        {
            FGestionFacturas facturas = new FGestionFacturas(_empleado);
            if (facturas != null)
            {
                _gestionFacturas = facturas;
                _gestionFacturas.MdiParent = this;
                _gestionFacturas.Show();
            }
            else
            {
                _gestionFacturas.BringToFront();
            }
        }

        private void panelDeControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FPanelControl panel = new FPanelControl(_empleado);

            _panelControl = panel;
            _panelControl.MdiParent = this;
            _panelControl.Show();
        }
    }
}

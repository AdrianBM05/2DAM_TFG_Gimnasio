using CAD.Instancias;
using System;
using Negocio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación
{
    public partial class FGestionFacturas: Form
    {

        public Empleado empleado;

        public FGestionFacturas(Empleado _empleado)
        {
            InitializeComponent();
            empleado = _empleado;
            this.WindowState = FormWindowState.Maximized;
            FPrincipal._gestionFacturas = this;

            //NVFacturas.actualizarFacturas(dsGimnasio1);
            NVFacturas.obtenerFacturas(dsGimnasio1);
            

        }

        public void FGestionFacturas_Load(object sender, EventArgs e)
        {
            
        }

        public void btnCrearFactura_Click(object sender, EventArgs e)
        {
            // ABrimos la ventana FFactura en el panel contenedor
            FFactura factura = new FFactura(0,0,this); // Crear = Nueva
            factura.TopLevel = false;
            contenedor.Controls.Remove(dataGridView1); // Borrar el dataGridView
            contenedor.Controls.Add(factura); // Añadir la factura
            // Edición de la factura en el panel contenedor
            factura.Dock = DockStyle.Fill;
            factura.FormBorderStyle = FormBorderStyle.None;


            factura.Show(); 

        }
    }
}

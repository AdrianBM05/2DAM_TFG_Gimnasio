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
    public partial class F_Factura : Form
    {
        private int id;
        private string nombreCliente;
        private string direccionCliente;
        private string emailCliente;

        public F_Factura(int _id)
        {
            InitializeComponent();
            this.CenterToParent();

            id = _id;
            NClientes.obtenerClienteID(dsGimnasio1, id);
        }

        private void F_Factura_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvDetallesFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

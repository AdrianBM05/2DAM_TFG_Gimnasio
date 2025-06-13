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
    public partial class FFichaProducto : Form
    {
        private int _id;

        public FFichaProducto(int id,int tipo)
        {
            InitializeComponent();
            this.CenterToScreen();
            NProductos.obtenerIVA(dsGimnasio1);
            NProductos.obtenerSecciones(dsGimnasio1);

            if (tipo == 0)
            {
                _id = 0;
                bsProductos.AddNew();
                
                
            } else if (tipo == 1)
            {
                _id = id;
                NProductos.obtenerProductoID(dsGimnasio1, _id);

            }

        }

        private void FProductoFicha_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            // GUardar PVP
            try
            {
                int IVA = 0;

                // CONDICIÓN IVA
                if (comboBoxIVA.SelectedIndex == 0)
                {
                     IVA = 21;
                }
                else if (comboBoxIVA.SelectedIndex == 1)
                {
                     IVA = 10;
                }
                else if (comboBoxIVA.SelectedIndex == 2)
                {
                     IVA = 4;
                }

                double BI = Convert.ToDouble(richTextBoxBaseImponible.Text);
                double pvp = NProductos.PVP(IVA, BI);

                ((DataRowView)bsProductos.Current).Row["PVP"] = pvp;
                richTextBoxPVP.Text = pvp.ToString();

                // Aplicar cambios o guardar producto
                bsProductos.EndEdit();

                NVProductos.actualizarProductos(dsGimnasio1);
               
                Close();


            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            


        }

        private void richTextBoxPVP_Leave(object sender, EventArgs e)
        {

        }

        private void FProductoFicha_Leave(object sender, EventArgs e)
        {
            NVProductos.actualizarProductos(dsGimnasio1);
            NVProductos.obtenerProductos(dsGimnasio1);
        }

        private void labelBaseImponible_Click(object sender, EventArgs e)
        {

        }

        private void FFichaProducto_Load(object sender, EventArgs e)
        {
            

        }

        private void richTextBoxPVP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

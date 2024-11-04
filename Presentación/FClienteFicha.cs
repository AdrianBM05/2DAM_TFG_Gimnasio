using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación
{
    public partial class FClienteFicha : Form
    {

        private int id;
        private DateTime fechaInicio;

        public FClienteFicha(int _id, int tipo, DateTime _fechaInicio)
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

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void FClienteFicha_Load(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                if (comboBoxTarifas.SelectedIndex == 0)
                {

                    ((DataRowView)bsClientes.Current).Row["Fecha_Caducidad_Tarifa"] = fechaInicio.AddMonths(1);
                }

                if (comboBoxTarifas.SelectedIndex == 1)
                {

                    ((DataRowView)bsClientes.Current).Row["Fecha_Caducidad_Tarifa"] = fechaInicio.AddMonths(3);
                }

                if (comboBoxTarifas.SelectedIndex == 2)
                {

                    ((DataRowView)bsClientes.Current).Row["Fecha_Caducidad_Tarifa"] = fechaInicio.AddMonths(1);
                }

                if (comboBoxTarifas.SelectedIndex == 3)
                { 

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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FClienteFicha_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void lblDatos_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class FClienteFicha2 : Form
    {
        private int id;
        private DateTime fechaInicio;
        /// <summary>
        /// Ficha de cliente
        /// </summary>
        /// <param name="_id">Id del cliente</param>
        /// <param name="tipo"></param>
        /// <param name="_fechaInicio"></param>
        public FClienteFicha2(int _id, int tipo, DateTime _fechaInicio) 
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

        private void FClienteFicha2_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FClienteFicha2_Load_1(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /*
             * Índice del comboBox = duración de tarifa
             * 1 mes / 3 meses / 1 año 
             */
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

                if (comboBoxTarifas.SelectedIndex == 2) // Mensual + Servicio.
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

        private void bsClientes_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            // Llamamos al formulario factura
            F_Factura factura = new F_Factura(this.id);
            factura.Show();
        }
    }
}

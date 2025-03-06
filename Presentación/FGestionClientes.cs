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
            FPrincipal._gestionClientes = this;


            lblUsuario.Text = "Bienvenido: " + _empleado.Nombre + " " + _empleado.Apellido;

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
            FPrincipal._gestionClientes = null;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {

            // Ajustar fecha actual de ese momento 
            DateTime actual = DateTime.Now;

            FFichaCliente ficha = new FFichaCliente(0,0,actual);
            ficha.Show();

            NVClientes.obtenerClientes(dsGimnasio1);


        }

        private void btnFicha_Click(object sender, EventArgs e)
        {

            // Abrir ficha del cliente
            if(bsVClientes.Count > 0)
            {
                FFichaCliente ficha = new FFichaCliente((int)((DataRowView)bsVClientes.Current).Row["Id"],1, (DateTime)((DataRowView)bsVClientes.Current).Row["Fecha_Inicio_Tarifa"]);
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

            string mensaje = $"📊 Ingresos Mensuales 📊\n\n" +
                             $"💰 Total: {ingresos}€\n" +
                             "----------------------------\n" +
                             "📅 Datos actualizados al mes actual";

            MessageBox.Show(mensaje, "Ingresos Mensuales", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {

            // Comprobar ficha caducada

            try
            {
                // Comprobar fecha de vencimiento > actual en todos los clientes
                foreach(DataRowView cliente in bsVClientes)
                {
                    DateTime fechaVencimiento = (DateTime)cliente.Row["Fecha_Caducidad_Tarifa"];
                    DateTime fechaActual = DateTime.Now;
                    if (fechaVencimiento < fechaActual)
                    {
                        NClientes.cambiarEstadoCliente((int)cliente.Row["Id"], 2);
                    }
                }

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
                // Cliente seleccionado
                int id = (int)(((DataRowView)bsVClientes.Current).Row[0]);
                string estado = (((DataRowView)bsVClientes.Current).Row["Estado"].ToString());

                if (id > 0)
                {
                    // Determinar nuevo estado y mensaje
                    string mensaje = "";
                    int nuevoEstado = 0;

                    if (estado == "Activo")
                    {
                        mensaje = "¿Desea dar de baja al cliente?";
                        nuevoEstado = 2; // Estado "Inactivo"
                    }
                    else if (estado == "Inactivo") // Corrigiendo "Desactivo"
                    {
                        mensaje = "¿Desea dar de alta al cliente?";
                        nuevoEstado = 1; // Estado "Activo"
                    }

                    // Confirmar cambio de estado
                    if (nuevoEstado > 0)
                    {
                        DialogResult rest = MessageBox.Show(mensaje, "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (rest == DialogResult.Yes)
                        {
                            NClientes.cambiarEstadoCliente(id, nuevoEstado);

                            // Refrescar datos tras el cambio de estado
                            bsVClientes.ResetBindings(false);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnF_Click(object sender, EventArgs e)
        {

        }

        private void btnFactura_Click(object sender, EventArgs e)
        {

            // Abrir ficha del cliente

        }

        private void btnFacturaNueva_Click(object sender, EventArgs e)
        {
            // Abrir ficha de cero
            FPlantillaFactura factura = new FPlantillaFactura(0,0); // CREACIÓN DE FACTURA NUEVA
            factura.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

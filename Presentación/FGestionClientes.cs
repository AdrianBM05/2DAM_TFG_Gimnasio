using CAD;
using CAD.Instancias;
using Microsoft.WindowsAPICodePack.Dialogs;
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

            NVClientes.actualizarClientes(dsGimnasio1);
            NVClientes.obtenerClientes(dsGimnasio1);
            NVClientes.obtenerEstado(dsGimnasio1);
        }

        private void FGestionClientes_Load(object sender, EventArgs e)
        {
            // Refrescamos los clientes para comprobar quien debe estar activo
            NVClientes.obtenerClientes(dsGimnasio1);
            actualizarEstadoAutomatico();
        }

        private void FGestionClientes_Leave(object sender, EventArgs e) { }

        private void FGestionClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            FPrincipal._gestionClientes = null;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string textoBuscar = txtBusqueda.Text;
            NVClientes.mostrarBusqueda(dsGimnasio1,textoBuscar);
        }


        private void btnIngresosMensuales_Click(object sender, EventArgs e)
            {
                double ingresos = NTarifas.calcularIngresosMensuales(dsGimnasio1);
                DateTime fechaActual = DateTime.Now;

                string mensaje = $"**Total ingresos:** {ingresos:C}\n" +
                                 $"**Mes actual:** {fechaActual:MMMM yyyy}\n" +
                                 $"Fuente: Tarifas de socios\n" +
                                 "--------------------------------------------\n" +
                                 "Datos actualizados automáticamente";

                TaskDialog dialog = new TaskDialog
                {
                    Caption = "Ingresos Mensuales",
                    InstructionText = "Resumen financiero del mes",
                    Text = mensaje,
                    Icon = TaskDialogStandardIcon.Information,
                    StandardButtons = TaskDialogStandardButtons.Ok
                };
                dialog.Show();
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
        private void btnFacturaNueva_Click(object sender, EventArgs e) { }

        private void verFichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abrimos la ficha del cliente
            if (bsVClientes.Count > 0)
            {
                FFichaCliente ficha = new FFichaCliente((int)((DataRowView)bsVClientes.Current).Row["Id"], 1, (DateTime)((DataRowView)bsVClientes.Current).Row["Fecha_Inicio_Tarifa"]);
                ficha.Show();
                NVClientes.obtenerClientes(dsGimnasio1);
            }
        }

        private void darDeBajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Comprobamos si el cliente está o no activo segun su fecha de caducidad
            if(bsVClientes.Count > 0)
            {
                // Fecha de caducidad pasada
                DateTime fechaVencimiento = (DateTime)((DataRowView)bsVClientes.Current).Row["Fecha_Caducidad_Tarifa"];
                DateTime fechaActual = DateTime.Now;
                // Comparar fechas
                if (fechaActual < fechaVencimiento)
                {
                    // Pregunta de confirmación
                    DialogResult rest = MessageBox.Show("¿Desea dar de baja al cliente?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (rest == DialogResult.Yes)
                    {
                        // Cambiar estado del cliente
                        NClientes.cambiarEstadoCliente((int)((DataRowView)bsVClientes.Current).Row["Id"], 2);
                        // Refrescar datos
                        NVClientes.obtenerClientes(dsGimnasio1);
                    }
                }
                else 
                {
                    // Dar de baja directamente
                    NClientes.cambiarEstadoCliente((int)((DataRowView)bsVClientes.Current).Row["Id"], 2);
                    
                }
            }
        } // Dar de baja
        private void actualizarEstadoAutomatico()
        {
            // Comprobar ficha caducada
            try
            {
                // Comprobar fecha de vencimiento > actual en todos los clientes
                foreach (DataRowView cliente in bsVClientes)
                {
                    DateTime fechaVencimiento = (DateTime)cliente.Row["Fecha_Caducidad_Tarifa"];
                    DateTime fechaActual = DateTime.Today;
                    if (fechaVencimiento < fechaActual)
                    {
                        NClientes.cambiarEstadoCliente((int)cliente.Row["Id"], 2);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            NVClientes.obtenerEstado(dsGimnasio1);
            NVClientes.actualizarClientes(dsGimnasio1);
            NVClientes.obtenerClientes(dsGimnasio1);
        }
        private void generarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abrir la ventana FGestionFacturas con este empleado, luego usar el boton de crear factura
            if (FPrincipal._gestionFacturas == null)
            {
                FPrincipal._gestionFacturas = new FGestionFacturas(_empleado);
                FPrincipal._gestionFacturas.MdiParent = FPrincipal._fPrincipalEmpleado;
                FPrincipal._gestionFacturas.Show();
                // Mostrar datos
                FPrincipal._gestionFacturas.BringToFront();
                // Cargar datos del cliente seleccionado
                int idCliente = (int)((DataRowView)bsVClientes.Current).Row["Id"];
                string apellidos = ((DataRowView)bsVClientes.Current).Row["Apellidos"].ToString();
                string DNI = ((DataRowView)bsVClientes.Current).Row["DNI"].ToString();
                string correo = ((DataRowView)bsVClientes.Current).Row["Correo"].ToString();

                // Cargar datos en la factura
                actualizarEstadoAutomatico();
            }
            else
            {
                FPrincipal._gestionFacturas.BringToFront();
            }
        }
        private void mensualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int idCliente = (int)((DataRowView)bsVClientes.Current).Row["Id"];
                NProcedimientos.generarFacturaCliente(idCliente, DateTime.Today, 36);

                NClientes.cambiarEstadoCliente(idCliente, 1); // Estado activo
                NClientes.cambiarTarifaCliente(idCliente, 1); // Tarifa mensual
                NClientes.cambiarFechasCliente(idCliente, DateTime.Today, 36); // Fecha de inicio hoy + 1 mes
                // Actualizar datos
                actualizarEstadoAutomatico();
                // Mensaje de confirmación
                string message = $"Factura para el cliente {idCliente} generada con éxito.\n" +
                                 $"\nTarifa: Mensual.\n" +
                                 $"\nFecha de caducidad: {DateTime.Now.AddMonths(1)}.\n";
                MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } // Generar factura mensual

        private void mensualSpinningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int idCliente = (int)((DataRowView)bsVClientes.Current).Row["Id"];

                NProcedimientos.generarFacturaCliente(idCliente, DateTime.Today, 38);

                NClientes.cambiarEstadoCliente(idCliente, 1); // Estado activo
                NClientes.cambiarTarifaCliente(idCliente, 3); // Tarifa mensual
                NClientes.cambiarFechasCliente(idCliente, DateTime.Today, 38); // Fecha de inicio hoy + 1 mes
                // Actualizar datos
                actualizarEstadoAutomatico();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } // Generar factura mensual de spinning

        private void trimestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int idCliente = (int)((DataRowView)bsVClientes.Current).Row["Id"];

                NProcedimientos.generarFacturaCliente(idCliente, DateTime.Today, 37);

                NClientes.cambiarEstadoCliente(idCliente, 1); // Estado activo
                NClientes.cambiarTarifaCliente(idCliente, 2); // Tarifa trimestral
                NClientes.cambiarFechasCliente(idCliente, DateTime.Today, 37); 
                // Actualizar datos
                actualizarEstadoAutomatico();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void anualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int idCliente = (int)((DataRowView)bsVClientes.Current).Row["Id"];

                NProcedimientos.generarFacturaCliente(idCliente, DateTime.Today, 39);

                NClientes.cambiarEstadoCliente(idCliente, 1); // Estado activo
                NClientes.cambiarTarifaCliente(idCliente, 4); // Tarifa anual
                NClientes.cambiarFechasCliente(idCliente, DateTime.Today, 39); 


                // Actualizar datos
                actualizarEstadoAutomatico();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Cuidado con las cabeceras
            if (e.RowIndex >= 0)
            {
                // Seleccionar la fila
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }

        }
        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Autenticación para eliminar un cliente 
            if (bsVClientes.Count > 0)
            {
                // Pregunta de confirmación
                DialogResult rest = MessageBox.Show("¿Desea eliminar al cliente?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (rest == DialogResult.Yes)
                {
                    // Cambiar estado del cliente
                    NClientes.eliminarCliente((int)((DataRowView)bsVClientes.Current).Row["Id"]);
                    // Refrescar datos
                    NVClientes.obtenerClientes(dsGimnasio1);
                }
            }

        }
    }
}

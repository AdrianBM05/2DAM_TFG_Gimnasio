using CAD.Instancias;
using System;
using Negocio;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using CAD.DSGimnasioTableAdapters;

namespace Presentación
{
    public partial class FGestionFacturas : Form
    {
        public Empleado empleado;

        public FGestionFacturas(Empleado _empleado)
        {
            InitializeComponent();
            empleado = _empleado;
            this.WindowState = FormWindowState.Maximized;
            FPrincipal._gestionFacturas = this;

            // Obtener todas las facturas al cargar
            NVFacturas.obtenerFacturas(dsGimnasio1);
        }

        public void FGestionFacturas_Load(object sender, EventArgs e) { }

        public void btnCrearFactura_Click(object sender, EventArgs e)
        {
            // Abrimos la ventana FFactura en el panel contenedor (modo creación)
            var factura = new FFactura(0, 0, this) { TopLevel = false, Dock = DockStyle.Fill, FormBorderStyle = FormBorderStyle.None };
            contenedor.Controls.Remove(dataGridView1);
            contenedor.Controls.Add(factura);
            factura.Show();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            // Editamos una factura existente
            try
            {
                var factura = new FFactura(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), 1, this) { TopLevel = false, Dock = DockStyle.Fill, FormBorderStyle = FormBorderStyle.None };
                contenedor.Controls.Remove(dataGridView1);
                contenedor.Controls.Add(factura);
                factura.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) =>
            dataGridView1.Rows[e.RowIndex].Selected = true;

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[0];
                facturasMenuStrip.Show(Cursor.Position);
            }
        }

        private void abrirFacturaToolStripMenuItem_Click(object sender, EventArgs e) => btnAbrir_Click(sender, e);
        private void editarFacturaToolStripMenuItem_Click(object sender, EventArgs e) => btnAbrir_Click(sender, e);

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) dataGridView1.Rows[e.RowIndex].Selected = true;
        }

        private void eliminarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea eliminar la factura?", "Eliminar Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    var ta = new VDesgloseTableAdapter();
                    ta.FillByIdFactura(dsGimnasio1.VDesglose, id);

                    foreach (DataRow row in dsGimnasio1.VDesglose.Rows)
                        NFactura.eliminarDesglose(dsGimnasio1, Convert.ToInt32(row["Id"]));

                    NFactura.eliminarFactura(dsGimnasio1, id);
                    NFactura.actualizarFacturas(dsGimnasio1);

                    MessageBox.Show("Factura eliminada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e) =>
            NFactura.actualizarFacturas(dsGimnasio1);

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            
        }

        private void generarPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                NFactura.obtenerFacturaId(dsGimnasio1, id);
                int idCliente = Convert.ToInt32(dsGimnasio1.Facturas.Rows[0]["Id_Cliente"]);
                var mostrarFactura = new FMostrarFactura(id, idCliente);
                mostrarFactura.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e) { } // sin uso actual

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBusqueda.Text;

            // Llamamos a la función de búsqueda
            if (string.IsNullOrEmpty(busqueda))
            {
                NVFacturas.obtenerFacturas(dsGimnasio1);
            }
            else
            {
                NVFacturas.obtenerFacturasByBusqueda(dsGimnasio1, busqueda);
            }
        }

        private void pagarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Modificar el estado de la factura a Pagada
            if (MessageBox.Show("¿Está seguro de que desea marcar la factura como pagada?", "Pagar Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    NFactura.pagarFactura(dsGimnasio1, id);
                    NFactura.actualizarFacturas(dsGimnasio1);
                    MessageBox.Show("Factura marcada como pagada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al pagar factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

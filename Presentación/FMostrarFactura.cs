using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAD;
using CAD.DSGimnasioTableAdapters;
using Negocio;

namespace Presentación
{
    public partial class FMostrarFactura : Form
    {
        int _id;
        int _idCliente;
        string nombreCliente;

        public FMostrarFactura(int id, int idCliente)
        {
            InitializeComponent();
            _id = id;
            _idCliente = idCliente;
        }

        private void FMostrarFactura_Load(object sender, EventArgs e)
        {
            // Ajustar la previsualización centrada en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;

            CargarDatos();
            ConfigurarReportViewer();

            // Si una factura no tiene desgloses, mostrar mensaje de que no se puede generar
            if (dsGimnasio1.FacturaDesglose.Rows.Count == 0)
            {
                MessageBox.Show("No se puede generar la factura porque no tiene desgloses.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            reportViewer1.RefreshReport();
            reportViewer1.RenderingComplete += ReportViewer1_RenderingComplete;

        }

        private void CargarDatos()
        {
            new FacturaDesgloseTableAdapter().FillByIdFactura(dsGimnasio1.FacturaDesglose, _id);
            new FacturasTableAdapter().FillById(dsGimnasio1.Facturas, _id);
            new ClientesTableAdapter().FillById(dsGimnasio1.Clientes, _idCliente);
            new VDesgloseTableAdapter().FillByIdFactura(dsGimnasio1.VDesglose, _id);
        }

        private void ConfigurarReportViewer()
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dsGimnasio1.Tables["FacturaDesglose"]));
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsFacturas", dsGimnasio1.Tables["Facturas"]));
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsClientes", dsGimnasio1.Tables["Clientes"]));
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsVDesglose", dsGimnasio1.Tables["VDesglose"]));
        }
        private async void ReportViewer1_RenderingComplete(object sender, Microsoft.Reporting.WinForms.RenderingCompleteEventArgs e)
        {
            // Obtener datos del cliente
            var clienteRow = dsGimnasio1.Clientes.FirstOrDefault();
            string nombre = "Nombre";
            string apellidos = "Apellidos";

            if (clienteRow != null)
            {
                nombre = clienteRow.Nombre?.Trim() ?? "Nombre";
                apellidos = clienteRow.Apellidos?.Trim() ?? "Apellidos";
            }

            // Limpiar caracteres no válidos
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                nombre = nombre.Replace(c.ToString(), "");
                apellidos = apellidos.Replace(c.ToString(), "");
            }

            // Crear carpeta "Facturas" en Escritorio si no existe
            string carpetaFacturas = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Facturas");
            if (!Directory.Exists(carpetaFacturas))
            {
                Directory.CreateDirectory(carpetaFacturas);
            }

            // Nombre del archivo: F_id_Apellidos_Nombre.pdf
            string nombreArchivo = $"Factura_{_id}_{apellidos}_{nombre}.pdf";
            string rutaCompleta = Path.Combine(carpetaFacturas, nombreArchivo);

            try
            {
                byte[] bytes = reportViewer1.LocalReport.Render("PDF");
                File.WriteAllBytes(rutaCompleta, bytes);

                if (clienteRow != null && !string.IsNullOrEmpty(clienteRow.Correo))
                {
                    string nombreCompleto = $"{nombre} {apellidos}";
                    await NFactura.enviarMail(rutaCompleta, clienteRow.Correo, nombreCompleto);
                }
                else 
                {
                    MessageBox.Show("No se pudo enviar el correo porque no se encontró la dirección de correo electrónico del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show($"Factura exportada correctamente a:\n{rutaCompleta}", "Exportación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar la factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
 
using CAD;
using CAD.DSGimnasioTableAdapters;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using MimeKit;
using MailKit.Net.Smtp;
using System.Threading.Tasks;
using System.IO;
using Outlook = Microsoft.Office.Interop.Outlook;


namespace Negocio
{
    public class NFactura
    {
        // Partes de la factura: Datos del cliente / Desglose.
        private DSGimnasio dsGimnasio1;

        // Filtrar productos por Tipo
        public static void findServicios(DSGimnasio ds,string tipo)
        {
            ProductosTableAdapter ta = new ProductosTableAdapter();
            ta.FillByTipo(ds.Productos,tipo);
        }


        public NFactura(DSGimnasio ds)
        {
            dsGimnasio1 = ds;
            FacturasTableAdapter ta = new FacturasTableAdapter();
            FacturaDesgloseTableAdapter taDesglose = new FacturaDesgloseTableAdapter();

        }

        // Crear factura en memoria

        public static void obtenerFacturaId(DSGimnasio ds, int id)
        {
            FacturasTableAdapter ta = new FacturasTableAdapter();
            ta.FillById(ds.Facturas,id);
        }

        public static void obtenerDesgloseFactura(DSGimnasio ds, int id)
        {
            FacturaDesgloseTableAdapter ta = new FacturaDesgloseTableAdapter();
            ta.FillByIdFactura(ds.FacturaDesglose, id);
        }

        // CAMBIOS EN LA BASE DE DATOS
        public static void actualizarFacturas(DSGimnasio ds)
        {
            try
            {
                FacturasTableAdapter ta = new FacturasTableAdapter();
                ta.Update(ds.Facturas);
                ds.Facturas.AcceptChanges();
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }
        public static void actualizarDesgloses(DSGimnasio dS)
        {
            try
            {
                FacturaDesgloseTableAdapter ta = new FacturaDesgloseTableAdapter();
                ta.Update(dS.FacturaDesglose);
                dS.FacturaDesglose.AcceptChanges();
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }

        // Obtener EstadoFactura, Envio , TipoPago
        public static void obtenerEstadoFactura(DSGimnasio ds)
        {
            EstadoFacturaTableAdapter ta = new EstadoFacturaTableAdapter();
            ta.Fill(ds.EstadoFactura);
        }

        public static void obtenerEnvio(DSGimnasio ds)
        {
            EnvioTableAdapter ta = new EnvioTableAdapter();
            ta.Fill(ds.Envio);
        }

        public static void obtenerTipoPago(DSGimnasio ds)
        {
            TipoPagoTableAdapter ta = new TipoPagoTableAdapter();
            ta.Fill(ds.TipoPago);
        }

        public static void obtenerDesgloseById(DSGimnasio ds, int id)
        {
            FacturaDesgloseTableAdapter ta = new FacturaDesgloseTableAdapter();
            ta.FillById(ds.FacturaDesglose, id);
        }

        public void generarFactura(string nombreCliente, string DNI, string correo,
                                    DateTime fechaEmision,DateTime fechaVencimiento, List<string> productos, decimal total)
        {
            string ruta = "C:\\Users\\abeja\\Desktop\\factura.pdf";
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(ruta, FileMode.Create));
            doc.Open();

            // Título del PDF
            doc.Add(new Paragraph("Factura", new Font(Font.FontFamily.HELVETICA, 18, Font.BOLD)));
            doc.Add(new Paragraph("\n"));

            // Adjuntamos cabecera (Datos del cliente)
            doc.Add(new Paragraph($"Cliente: {nombreCliente}"));
            doc.Add(new Paragraph($"DNI: {DNI}"));
            doc.Add(new Paragraph($"Correo: {correo}"));
            doc.Add(new Paragraph($"Fecha de emisión: {fechaEmision.ToShortDateString()}"));
            doc.Add(new Paragraph($"Fecha de vencimiento: {fechaVencimiento.ToShortDateString()}"));
            doc.Add(new Paragraph("\n"));

            // Tabla para los productos vendidos
            PdfPTable table = new PdfPTable(1);
            table.AddCell("Productos");

            foreach(var producto in productos)
            {
                table.AddCell(producto);
            }
            doc.Add(table);
            doc.Add(new Paragraph());

            doc.Add(new Paragraph($"Total de la factura = {total}"));
            doc.Close();
            System.Diagnostics.Process.Start(ruta);

        }

        // FUnción para eliminar una factura
        public static void eliminarFactura(DSGimnasio ds, int id)
        {
            try
            {
                FacturasTableAdapter ta = new FacturasTableAdapter();
                ta.DeleteById(id);
                ds.Facturas.AcceptChanges();
            }
            catch (Exception e)
            {
                 throw new ArgumentException(e.Message);
            }
        }

        public static void eliminarDesglose(DSGimnasio dsGimnasio1, int idDesglose)
        {
            // Eliminar el desglose de la base de datos
            try
            {
                FacturaDesgloseTableAdapter ta = new FacturaDesgloseTableAdapter();
                ta.DeleteById(idDesglose);
                dsGimnasio1.FacturaDesglose.AcceptChanges();
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }

        public static void cambiarEstado(DSGimnasio dsGimnasio1, int id, int idEstado)
        {
            // Cambiar el estado de la factura : 0 = Pendiente, 1 = Pagada
            try
            {
                FacturasTableAdapter ta = new FacturasTableAdapter();
                ta.UpdateEstadoById(idEstado, id);
                dsGimnasio1.Facturas.AcceptChanges();
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }

        /* 
         * ENVIAR CORREO ELECTRÓNICO 
         */
        public static async Task enviarMail(string rutaPDF, string correoCliente, string cliente)
        {
            try
            {
                Outlook.Application outlookApp = new Outlook.Application();
                Outlook.MailItem mail = (Outlook.MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);

                // Asunto personalizado
                mail.Subject = $"Documento para {cliente}";

                // Destinatario dinámico (se aplica aquí)
                mail.To = correoCliente;

                // Cuerpo del mensaje
                mail.Body = $"Hola {cliente},\n\nAdjunto encontrarás el documento solicitado.\n\nSaludos,\nGimnasio Sport";

                // Prioridad normal
                mail.Importance = Outlook.OlImportance.olImportanceNormal;

                // Adjuntar archivo PDF si existe
                if (!string.IsNullOrEmpty(rutaPDF) && System.IO.File.Exists(rutaPDF))
                {
                    mail.Attachments.Add(rutaPDF, Outlook.OlAttachmentType.olByValue, Type.Missing, Type.Missing);
                }

                // Enviar el correo
                mail.Send();
                // mail.Display();
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Error al enviar el correo: {ex.Message}");
            }
        }

        public static void pagarFactura(DSGimnasio dsGimnasio1, int id)
        {
            // Cambiamos el estado de la factura a Pagada

            try
            {
                FacturasTableAdapter ta = new FacturasTableAdapter();
                ta.UpdateEstadoById(1, id);
                dsGimnasio1.Facturas.AcceptChanges();
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }

        }
    }
}

using CAD;
using CAD.DSGimnasioTableAdapters;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}

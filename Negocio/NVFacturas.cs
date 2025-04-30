using CAD;
using CAD.DSGimnasioTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NVFacturas
    {

        public static void obtenerFacturas(DSGimnasio ds)
        {
            try
            {
                VFacturasTableAdapter ta = new VFacturasTableAdapter();
                ta.Fill(ds.VFacturas);
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }

        public static void obtenerFacturasByBusqueda(DSGimnasio ds, int id)
        {
            try
            {
                // Obtener la vista de una factura por el id
                VFacturasTableAdapter ta = new VFacturasTableAdapter();
                ta.FillById(ds.VFacturas, id);

            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }

        public static void obtenerFacturasByBusqueda(DSGimnasio ds, string busqueda)
        {
            try
            {
                // Obtener la vista de una factura por el id
                VFacturasTableAdapter ta = new VFacturasTableAdapter();
                ta.FillByBusqueda(ds.VFacturas, busqueda);
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }


    }
}

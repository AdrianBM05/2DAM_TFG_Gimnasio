using CAD;
using CAD.DSGimnasioTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NVDesglose
    {

        // Método para obtener los desgloses de una factura
        public static void obtenerDesglosesByIdFactura(DSGimnasio ds, int id)
        {
            try
            {
                // Obtener los desgloses de una factura por el id de la factura
                VDesgloseTableAdapter ta = new VDesgloseTableAdapter();
                ta.FillByIdFactura(ds.VDesglose, id);
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }

        // Función para actualizar la vista
        public static void actualizarDesglose(DSGimnasio ds)
        {
            try
            {
                // Actualizar la vista
                VDesgloseTableAdapter ta = new VDesgloseTableAdapter();
                // Actualizar la vista
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }

        public static void eliminarDesglose(DSGimnasio ds, int id)
        {
            try
            {
                // Eliminar un desglose por el id
                FacturaDesgloseTableAdapter ta = new FacturaDesgloseTableAdapter();
                ta.DeleteById(id);
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }


    }
}

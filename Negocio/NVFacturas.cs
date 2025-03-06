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

        public static void obtenerFacturasById(DSGimnasio ds, int id)
        {
            try
            {
                
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }

        

        


    }
}

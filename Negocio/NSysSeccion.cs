using CAD;
using CAD.DSGimnasioTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NSysSeccion
    {

        public static void llenarSecciones(DSGimnasio ds)
        {

            try
            {

                SeccionesTableAdapter ta = new SeccionesTableAdapter();
                ta.Fill(ds.Secciones);

            } catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }

        }

    }
}

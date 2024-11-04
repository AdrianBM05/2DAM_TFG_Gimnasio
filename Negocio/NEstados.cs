using CAD;
using CAD.DSGimnasioTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NEstados
    {

        public static void obtenerEstados(DSGimnasio ds)
        {

            try
            {
                EstadoTableAdapter ta = new EstadoTableAdapter();
                ta.Fill(ds.Estado);

            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }

        }


    }
}

using CAD;
using CAD.DSGimnasioTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NVProductos
    {

        // Obtener productos

        public static void obtenerProductos(DSGimnasio ds)
        {

            try
            {
                VProductosTableAdapter ta = new VProductosTableAdapter();
                ta.Fill(ds.VProductos);
            }
            catch (Exception e) 
            {
                throw new Exception(e.Message);
            }

        }

        public static void actualizarProductos(DSGimnasio ds)
        {

            try
            {

                ProductosTableAdapter ta = new ProductosTableAdapter();
                ta.Update(ds.Productos);

            } catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }


        // MOstrar vista con filtros depende el botón que se selecciones
        public static void verFiltro(DSGimnasio ds, string filtro)
        {

            // Mostrar vista cumpliendo un filtro
            try
            {

                VProductosTableAdapter ta = new VProductosTableAdapter();
                

            } catch(Exception e)
            {
                throw new Exception(e.Message);
            }

        }


    }
}

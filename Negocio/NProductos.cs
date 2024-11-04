using CAD;
using CAD.DSGimnasioTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NProductos
    {

        // Aplicar filtros sobre productos
        public static void filtrar(DSGimnasio ds, String filtro)
        {

            // Fitro = Boton



        }

        public static void obtenerProductos(DSGimnasio ds)
        {

            ProductosTableAdapter ta = new ProductosTableAdapter();
            ta.Fill(ds.Productos);

        }

        public static void obtenerProductoID(DSGimnasio ds, int id)
        {

            ProductosTableAdapter ta =new ProductosTableAdapter();
            ta.FillById(ds.Productos, id);

        }

        // HAGO AQUÍ NIVA e NSeccion

        public static void obtenerSecciones(DSGimnasio ds)
        {

            try
            {
                SeccionesTableAdapter ta = new SeccionesTableAdapter();
                ta.Fill(ds.Secciones);

            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }

        }

        public static void obtenerIVA(DSGimnasio ds)
        {

            try
            {
                Tipo_IVATableAdapter ta = new Tipo_IVATableAdapter();
                ta.Fill(ds.Tipo_IVA);

            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }

        }


        // FUNCIÓN PARA CALCULAR EL PVP
        public static double PVP(int IVA, double BI)
        {

            return BI * (1 + (IVA / 100.0));

        }


        public static void mostrarBusqueda(DSGimnasio ds, string texto)
        {

            try
            {
                VProductosTableAdapter ta = new VProductosTableAdapter();
                ta.FillByBusqueda(ds.VProductos, texto);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }


        } // Busqueda de producto

    }
}

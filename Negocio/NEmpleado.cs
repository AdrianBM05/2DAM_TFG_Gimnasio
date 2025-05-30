using CAD.DSGimnasioTableAdapters;
using CAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NEmpleado
    {

        public static void obtenerEmpleado(DSGimnasio ds, string nombre)
        {
            try
            {
                EmpleadosTableAdapter ta = new EmpleadosTableAdapter();
                ta.FillByUsuario(ds.Empleados, nombre);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        // Todos los clientes
        public static void mostrarEmpleados(DSGimnasio ds)
        {

            try
            {
                EmpleadosTableAdapter ta = new EmpleadosTableAdapter();
                ta.Fill(ds.Empleados);
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }

        }

        // Actualilzar
        public static void actualizarEmpleados(DSGimnasio ds)
        {

            try
            {
                EmpleadosTableAdapter ta = new EmpleadosTableAdapter();
                ta.Update(ds.Empleados);
                ds.Empleados.AcceptChanges();
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }

        }

    }
}

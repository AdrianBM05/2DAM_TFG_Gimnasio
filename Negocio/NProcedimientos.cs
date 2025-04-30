using CAD;
using CAD.DSGimnasioTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NProcedimientos
    {

        public static void generarFacturaCliente(int idCliente,DateTime fechaEmision,int idProducto)
        {

            try
            {

                QueriesTableAdapter ta = new QueriesTableAdapter();
                ta.GenerarFacturas(idProducto,fechaEmision,idCliente);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
  

        }


        public static int ObtenerClientesActivos(DSGimnasio ds, int mes, int año)
        {
            try
            {
                QueriesTableAdapter ta = new QueriesTableAdapter();

                object resultado = ta.ObtenerClientesActivos(mes, año);

                return resultado != null ? Convert.ToInt32(resultado) : 0;

            }
            catch (Exception e)
            {
                throw new Exception($"Error obteniendo clientes activos: {e.Message}");
            }
        }

        public static decimal obtenerIngresosSemanales(DSGimnasio ds, DateTime fechaInicio, DateTime fechaFin) 
        {
            // Calcula los ingresos semanales entre dos fechas
            try
            {
                QueriesTableAdapter ta = new QueriesTableAdapter();
                object resultado = ta.CalcularIngresosSemanales(fechaInicio, fechaFin);
                return resultado != null ? Convert.ToDecimal(resultado) : 0;
            }
            catch (Exception e)
            {
                throw new Exception($"Error obteniendo ingresos semanales: {e.Message}");
            }
        }


    }
}

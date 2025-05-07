using CAD;
using CAD.DSGimnasioTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NProcedimientos
    {
        public static void generarFacturaCliente(int idCliente, DateTime fechaEmision, int idProducto)
        {
            try
            {
                QueriesTableAdapter ta = new QueriesTableAdapter();
                ta.GenerarFacturas(idProducto, fechaEmision, idCliente);
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
            catch (Exception ex)
            {
                throw new Exception("Error al obtener clientes activos: " + ex.Message);
            }
        }

        public static DataTable obtenerIngresosSemanales(DSGimnasio ds, DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                CalcularIngresosSemanalesTableAdapter ta = new CalcularIngresosSemanalesTableAdapter();
                return ta.GetData(fechaInicio, fechaFin);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los ingresos semanales: " + ex.Message);
            }
        }
    }
}

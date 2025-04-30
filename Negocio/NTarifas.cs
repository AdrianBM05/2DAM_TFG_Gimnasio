using CAD;
using CAD.DSGimnasioTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NTarifas
    {

        public static void obtenerTarifas(DSGimnasio ds)
        {

            try
            {
                TarifasTableAdapter ta = new TarifasTableAdapter();
                ta.Fill(ds.Tarifas);

            } catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }

        }


        // Ingresos mensuales en base a las tarifas
        public static double calcularIngresosMensuales(DSGimnasio ds)
        {
            double ingresosTotales = 0;

            foreach (DSGimnasio.VClientesRow cliente in ds.VClientes)
            {
                // Asegura que "Activo" es detectado aunque venga mal escrito
                if (cliente.Estado.Trim().ToLower() == "activo")
                {
                    switch (cliente.TipoTarifa.Trim().ToLower())
                    {
                        case "mensual":
                            ingresosTotales += 35;
                            break;
                        case "trimestral":
                            ingresosTotales += 75 / 3;
                            break;
                        case "mensual + spining":
                            ingresosTotales += 40;
                            break;
                        case "anual":
                            ingresosTotales += 400 / 12;
                            break;
                    }
                }
            }

            return ingresosTotales;
        }

        public static int contarClientesActivos(DSGimnasio ds)
        {
            return ds.VClientes.Count(c => c.Estado.Trim().ToLower() == "activo");
        }




    }
}

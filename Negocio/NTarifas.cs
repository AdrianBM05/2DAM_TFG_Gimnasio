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
                // Activo o de baja
                if(cliente.Estado == "Activo")
                {

                    // Comprobar tarifa

                    switch (cliente.TipoTarifa)
                    {

                        case "Mensual":
                            ingresosTotales += 35;
                            break;
                        case "Trimestral":
                            ingresosTotales += 75 / 3; 
                            break;
                        case "Mensual + Spining":
                            ingresosTotales += 40;
                            break;
                        case "Anual":
                            ingresosTotales += 400 / 12;
                            break;

                    }
                }


            }

            return ingresosTotales;


        }


    }
}

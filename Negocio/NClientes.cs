using CAD;
using CAD.DSGimnasioTableAdapters;
using System;

namespace Negocio
{
    public class NClientes
    {
        public static void obtenerClientes(DSGimnasio ds, string nombre)
        {
            try
            {
                ClientesTableAdapter ta = new ClientesTableAdapter();
                ta.FillByUsuario(ds.Clientes, nombre);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void obtenerClienteID(DSGimnasio ds, int id)
        {
            try
            {
                ClientesTableAdapter ta = new ClientesTableAdapter();
                ta.FillById(ds.Clientes, id);
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }

        public static void mostrarClientes(DSGimnasio ds)
        {
            try
            {
                ClientesTableAdapter ta = new ClientesTableAdapter();
                ta.Fill(ds.Clientes);
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }

        public static void actualizarClientes(DSGimnasio ds)
        {
            try
            {
                ClientesTableAdapter ta = new ClientesTableAdapter();
                ta.Update(ds.Clientes);
                ds.Clientes.AcceptChanges();
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }

        public static void mostrarBusqueda(DSGimnasio ds, string texto)
        {
            try
            {
                ClientesTableAdapter ta = new ClientesTableAdapter();
                ta.FillByBusqueda(ds.Clientes, texto);
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }

        public static void actualizarEstadoCliente(DSGimnasio ds)
        {
            try
            {
                ClientesTableAdapter ta = new ClientesTableAdapter();
                ta.Fill(ds.Clientes);
                DateTime fechaActual = DateTime.Now;

                foreach (var cliente in ds.Clientes)
                {
                    if (cliente.Fecha_Caducidad_Tarifa != null && cliente.Fecha_Caducidad_Tarifa.Equals(fechaActual))
                    {
                        cliente.Id_Estado = 2;
                    }
                    else
                    {
                        cliente.Id_Estado = 1;
                    }
                }
                ta.Update(ds.Clientes);
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }

        public static void cambiarEstadoCliente(int id, int nuevoEstado)
        {
            try
            {
                ClientesTableAdapter ta = new ClientesTableAdapter();
                ta.UpdateEstadoById(nuevoEstado, id);
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }

        public static void cambiarTarifaCliente(int id, int idTarifa)
        {
            try
            {
                ClientesTableAdapter ta = new ClientesTableAdapter();
                ta.UpdateTarifaById(idTarifa, id);
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }

        public static void cambiarFechasCliente(int id, DateTime fechaInicio, int idTarifa)
        {
            try
            {
                ClientesTableAdapter ta = new ClientesTableAdapter();

                // Condiciones con la tarifa
                if (idTarifa != 36 && idTarifa != 37 && idTarifa != 38 && idTarifa != 39)
                {
                    // Tarifa no válida -> Lanzar error
                    throw new ArgumentException("Tarifa no válida");
                }
                else if (idTarifa == 36)
                {
                    ta.UpdateFechasTarifaById(fechaInicio.AddMonths(1), fechaInicio, id);
                }
                else if (idTarifa == 37)
                {
                    ta.UpdateFechasTarifaById(fechaInicio.AddMonths(3), fechaInicio, id);
                }
                else if (idTarifa == 38)
                { 
                    ta.UpdateFechasTarifaById(fechaInicio.AddMonths(1), fechaInicio, id);
                }
                else if (idTarifa == 39)
                {
                    ta.UpdateFechasTarifaById(fechaInicio.AddYears(1), fechaInicio, id);
                }


            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }

        }

        public static void eliminarCliente(int id)
        {
            try
            {
                ClientesTableAdapter ta = new ClientesTableAdapter();
                ta.DeleteById(id);
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }

        /*
         * GRÁFICOS DEL PANEL DE CONTROL:
         * Objetivo: mostrar clientes activos cada mes
         * Propuesta: 
         * Cuando un cliente se activa, se registra una factura a priori "pagada" en el momento.
         * Ir recolectando facturas de mensualidades por cada mes y mostrarlas en el gráfico.
         * TO DO: Distinguir facturas de mensualidades con facturas de compras
         * ¿Qué pasa cuando una factura es anual o trimestral?
         * 
         */
        public static void ObtenerClientesActivos(DSGimnasio ds, DateTime fechaMes)
        {
            try
            {
                ClientesTableAdapter ta = new ClientesTableAdapter();

                // Calcular inicio y fin de mes automáticamente
                DateTime fechaInicioMes = new DateTime(fechaMes.Year, fechaMes.Month, 1);
                DateTime fechaFinMes = fechaInicioMes.AddMonths(1).AddDays(-1);

                // Llamar al nuevo método FillByClientesActivos
                ta.FillByActivoPorMes(ds.Clientes, fechaInicioMes, fechaFinMes);
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }




    }
}
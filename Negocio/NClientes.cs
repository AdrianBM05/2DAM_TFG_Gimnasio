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
            catch(Exception e)
            {
                throw new ArgumentException(e.Message);
            }


        }

        // Todos los clientes
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

        // Actualilzar
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


        // BORRAR X, DAR DE BAJA


        public static void mostrarBusqueda(DSGimnasio ds, string texto)
        {

            try
            {
                ClientesTableAdapter ta = new ClientesTableAdapter();
                ta.FillByBusqueda(ds.Clientes,texto);
            }
            catch (Exception ex) 
            {
                throw new ArgumentException(ex.Message);
            }


        } // Busqueda de clietne


        // Actualizar el estado cuando caduque la tarifa
        public static void actualizarEstadoCliente(DSGimnasio ds)
        {

            try
            {
                ClientesTableAdapter ta = new ClientesTableAdapter();

                ta.Fill(ds.Clientes);

                // Fecha actual
                DateTime fechaActual = DateTime.Now;


                // Recorrer clientes para comprobar cuando caduca
                foreach (var cliente in ds.Clientes)
                {
                    if(cliente.Fecha_Caducidad_Tarifa != null && cliente.Fecha_Caducidad_Tarifa.Equals(fechaActual))
                    {
                        cliente.Id_Estado = 2; // De baja 
                    }
                }

                ta.Update(ds.Clientes);

            } catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }


        }



        // Dar de baja o alta
        public static void cambiarEstadoCliente(int id, int nuevoEstado)
        {

            ClientesTableAdapter ta= new ClientesTableAdapter();

            ta.UpdateEstadoById(nuevoEstado, id);


        }

    }
}

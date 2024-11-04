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
    public class NVClientes
    {

        public static void obtenerClientes(DSGimnasio ds)
        {

            try
            {

                VClientesTableAdapter ta = new VClientesTableAdapter();
                ta.Fill(ds.VClientes);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
  

        }

        public static void obtenerVClienteID(DSGimnasio ds, int id)
        {
            try
            {
                VClientesTableAdapter ta = new VClientesTableAdapter();
                ta.FillById(ds.VClientes, id);
            }
            catch(Exception e)
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
                VClientesTableAdapter ta = new VClientesTableAdapter();
                ta.FillByBusqueda(ds.VClientes, texto);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }


        } // Busqueda de clietne

        public static void obtenerEstado(DSGimnasio ds)
        {

            DateTime actual = DateTime.Today;
            foreach(DataRow cliente in ds.Clientes.Rows)
            {
                DateTime fechaFin = DateTime.Parse(cliente["Fecha_Caducidad"].ToString());

                if (fechaFin < actual)
                {
                    cliente["Estado"] = 2;
                }

            }

        }

    }
}

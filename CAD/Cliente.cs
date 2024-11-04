using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD
{
    public class Cliente
    {

        // Instancio un cliente
        private int id;
        private string nombre;
        private string apellido;
        private string DNI;
        private string direccion;
        private int tarifa;
        private string usuario;
        private string contraseña;
        private string correo;
        private int tipocuenta;
        private int estado;

        public Cliente(int id,string nombre, string apellido, string DNI,string direccion, int tarifa, string usuario, string contraseña, string correo, int tipocuenta, int estado)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.DNI = DNI;
            this.direccion = direccion;
            this.tarifa = tarifa;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.correo = correo;
            this.tipocuenta = tipocuenta;
            this.estado = estado;
        }

        public int Id { get => id; set => id = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string DNI1 { get => DNI; set => DNI = value; }
        public int Tarifa { get => tarifa; set => tarifa = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Tipocuenta { get => tipocuenta; set => tipocuenta = value; }
        public int Estado { get => estado; set => estado = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}

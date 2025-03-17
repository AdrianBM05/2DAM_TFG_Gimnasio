using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class FacturaDesglose
    {

        public int IdFactura { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal BaseImponible { get; set; }
        public string Concepto { get; set; }
        public int IdTipoIVA { get; set; }
        public FacturaDesglose()
        {
            IdFactura = 0;
            IdProducto = 0;
            Cantidad = 0;
            BaseImponible = 0;
            Concepto = "";
            IdTipoIVA = 0;
        }
        public FacturaDesglose(int idFactura, int idProducto, int cantidad, decimal baseImponible, string concepto, int idTipoIVA)
        {
            IdFactura = idFactura;
            IdProducto = idProducto;
            Cantidad = cantidad;
            BaseImponible = baseImponible;
            Concepto = concepto;
            IdTipoIVA = idTipoIVA;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Facturacion.Clases
{
    class Factura
    {
        public string Descrpcion { get; set; }
        public int Cantidad { get; set; }
        public string Precio_Unitario { get; set; }
        public string Total { get; set; }
    }
}

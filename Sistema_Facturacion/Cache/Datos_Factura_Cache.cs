using Sistema_Facturacion.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Facturacion.Cache
{
    class Datos_Factura_Cache
    {

        public static List<Articulos_Vendidos> List_articulos_Vendidos = new List<Articulos_Vendidos>();
        
        public static List<Articulos_Vendidos> Get_Productos { get; set; }
        public static decimal Monto_Cobrar { get; set; }

        public Datos_Factura_Cache()
        {
            Get_Productos = new List<Articulos_Vendidos>();
        }

        public static void Agregar(Articulos_Vendidos producto, decimal MontoACobrar)
        {

            //var Articulos = new Articulos_Vendidos
            //{
            //    Nombre_Articulo = producto.Nombre_Articulo,
            //    Cantidad = producto.Cantidad,
            //    Precio_Unitario = producto.Precio_Unitario,
            //    Precio_Total = producto.Precio_Unitario,
            //    Id_Producto = producto.Id_Producto,
            //    Id_Factura = 0

            //};

            //Get_Productos.Add(Articulos);
            //Monto_Cobrar = MontoACobrar;

        }

    }
    

}

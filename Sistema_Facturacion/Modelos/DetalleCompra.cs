//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sistema_Facturacion.Modelos
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleCompra
    {
        public int idCompra { get; set; }
        public int idProducto { get; set; }
        public int cantidadCompra { get; set; }
        public decimal precioCompra { get; set; }
        public decimal ImporteCompra { get; set; }
        public int idDetalleC { get; set; }
    
        public virtual Compra Compra { get; set; }
        public virtual Producto Producto { get; set; }
    }
}

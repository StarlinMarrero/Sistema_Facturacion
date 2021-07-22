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
    
    public partial class Compra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Compra()
        {
            this.ComprobantePagoEntradas = new HashSet<ComprobantePagoEntrada>();
            this.DetalleCompras = new HashSet<DetalleCompra>();
        }
    
        public int idCompra { get; set; }
        public int idVendedor { get; set; }
        public int idProveedor { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Igv { get; set; }
        public decimal TotalCompra { get; set; }
        public System.DateTime fechaCompra { get; set; }
        public bool CpEli { get; set; }
        public string MotivoEli { get; set; }
    
        public virtual Proveedor Proveedor { get; set; }
        public virtual Vendedor Vendedor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComprobantePagoEntrada> ComprobantePagoEntradas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleCompra> DetalleCompras { get; set; }
    }
}

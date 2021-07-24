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
    
    public partial class Factura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Factura()
        {
            this.ComprobantePagoes = new HashSet<ComprobantePago>();
            this.Detalles = new HashSet<Detalle>();
        }
    
        public int num_fact { get; set; }
        public int IdVendedor { get; set; }
        public int IdCliente { get; set; }
        public decimal Sub_total { get; set; }
        public decimal Igv { get; set; }
        public decimal Total { get; set; }
        public System.DateTime Fecha { get; set; }
        public bool FgEli { get; set; }
        public string MotivoEli { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComprobantePago> ComprobantePagoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle> Detalles { get; set; }
        public virtual Vendedor Vendedor { get; set; }
    }
}
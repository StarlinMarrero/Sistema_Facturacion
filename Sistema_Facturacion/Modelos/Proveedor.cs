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
    
    public partial class Proveedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proveedor()
        {
            this.Compras = new HashSet<Compra>();
        }
    
        public int idProveedor { get; set; }
        public string nombreProveedor { get; set; }
        public string RUCProveedor { get; set; }
        public string direccionProveedor { get; set; }
        public string TelefonoProveedor { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public bool EstadoProveedor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Compra> Compras { get; set; }
    }
}

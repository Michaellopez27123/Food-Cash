//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Food_Cash_Proyecto_Final.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Persona
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Persona()
        {
            this.factura = new HashSet<factura>();
        }
    
        public long identificacion { get; set; }
        public string t_documento { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public Nullable<long> telefono { get; set; }
        public string correo { get; set; }
        public int id_rol { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<factura> factura { get; set; }
        public virtual Rol Rol { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}

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
    
    public partial class Ventas
    {
        public int id_venta { get; set; }
        public int id_factura { get; set; }
        public int id_producto { get; set; }
        public Nullable<int> cantidad { get; set; }
        public Nullable<double> precio { get; set; }
    
        public virtual factura factura { get; set; }
        public virtual Producto Producto { get; set; }
    }
}

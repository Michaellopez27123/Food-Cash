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
    
    public partial class Usuario
    {
        public long id_usuario { get; set; }
        public string contrasena { get; set; }
        public string estado { get; set; }
    
        public virtual Persona Persona { get; set; }
    }
}

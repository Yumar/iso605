//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ISO605_WindowsForms.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuario
    {
        public System.Guid usuario_id { get; set; }
        public string codigo_usuario { get; set; }
        public byte[] contrasena { get; set; }
        public System.Guid emplado_id { get; set; }
    
        public virtual empleado empleado { get; set; }
    }
}

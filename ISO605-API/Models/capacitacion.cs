//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ISO605_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class capacitacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public capacitacion()
        {
            this.candidatoes = new HashSet<candidato>();
        }
    
        public System.Guid capacitaciones_id { get; set; }
        public string descripcion { get; set; }
        public Nullable<System.Guid> nivel { get; set; }
        public Nullable<System.DateTime> fecha_desde { get; set; }
        public Nullable<System.DateTime> fecha_hasta { get; set; }
        public string nombre_institucion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<candidato> candidatoes { get; set; }
    }
}

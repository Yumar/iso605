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
    
    public partial class empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public empleado()
        {
            this.candidatoes = new HashSet<candidato>();
        }
    
        public System.Guid empleado_id { get; set; }
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public System.DateTime fecha_ingreso { get; set; }
        public System.Guid posicion { get; set; }
        public decimal salario { get; set; }
        public string estado { get; set; }
        public Nullable<System.Guid> perfil_candidato { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<candidato> candidatoes { get; set; }
        public virtual candidato candidato { get; set; }
        public virtual posicion posicion1 { get; set; }
    }
}

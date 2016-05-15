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
    
    public partial class posicion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public posicion()
        {
            this.candidatoes = new HashSet<candidato>();
            this.empleadoes = new HashSet<empleado>();
        }
    
        public System.Guid posicion_id { get; set; }
        public string nombre { get; set; }
        public Nullable<decimal> riesgo { get; set; }
        public Nullable<decimal> salario_minimo { get; set; }
        public Nullable<decimal> salario_maximo { get; set; }
        public string estado { get; set; }
        public System.Guid departamento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<candidato> candidatoes { get; set; }
        public virtual departamento departamento1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<empleado> empleadoes { get; set; }
    }
}

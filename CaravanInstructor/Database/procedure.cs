//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CaravanInstructor.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class procedure
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public procedure()
        {
            this.exercise = new HashSet<exercise>();
        }
    
        public int procedure_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int system_id { get; set; }
        public int procedure_type_id { get; set; }
        public int action_id { get; set; }
    
        public virtual action action { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<exercise> exercise { get; set; }
        public virtual procedure_type procedure_type { get; set; }
        public virtual system system { get; set; }
    }
}
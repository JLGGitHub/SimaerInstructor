namespace CaravanInstructor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.procedure")]
    public partial class procedure
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public procedure()
        {
            exercise = new HashSet<exercise>();
        }

        [Key]
        public int procedure_id { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [Required]
        [StringLength(500)]
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

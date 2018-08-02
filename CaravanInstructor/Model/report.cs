namespace CaravanInstructor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.report")]
    public partial class report
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public report()
        {
            exercise = new HashSet<exercise>();
        }

        [Key]
        public int report_id { get; set; }

        public int scenario_id { get; set; }

        [Required]
        [StringLength(25)]
        public string instructor_code { get; set; }

        [Required]
        [StringLength(25)]
        public string student_code { get; set; }

        [Column(TypeName = "date")]
        public DateTime start_time { get; set; }

        [Column(TypeName = "date")]
        public DateTime? end_time { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<exercise> exercise { get; set; }

        public virtual pilot pilot { get; set; }

        public virtual pilot pilot1 { get; set; }

        public virtual scenario scenario { get; set; }
    }
}

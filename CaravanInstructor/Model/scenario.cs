namespace CaravanInstructor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.scenario")]
    public partial class scenario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public scenario()
        {
            report = new HashSet<report>();
        }

        [Key]
        public int scenario_id { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        public int runway_tol_id { get; set; }

        public int time_day_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<report> report { get; set; }

        public virtual runway_tol runway_tol { get; set; }

        public virtual time_day time_day { get; set; }
    }
}

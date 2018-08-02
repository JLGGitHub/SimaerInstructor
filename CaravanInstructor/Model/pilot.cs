namespace CaravanInstructor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.pilot")]
    public partial class pilot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pilot()
        {
            report = new HashSet<report>();
            report1 = new HashSet<report>();
        }

        [Key]
        [StringLength(25)]
        public string militar_code { get; set; }

        [Required]
        [StringLength(200)]
        public string first_name { get; set; }

        [Required]
        [StringLength(200)]
        public string last_name { get; set; }

        public int grade_id { get; set; }

        public virtual grade grade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<report> report { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<report> report1 { get; set; }
    }
}

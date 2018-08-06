namespace CaravanInstructor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.action")]
    public partial class action
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public action()
        {
            procedure = new HashSet<procedure>();
        }

        [Key]
        public int action_id { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        public int data_type_1_id { get; set; }

        public int? data_type_2_id { get; set; }

        public virtual data_type data_type { get; set; }

        public virtual data_type data_type1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<procedure> procedure { get; set; }
    }
}

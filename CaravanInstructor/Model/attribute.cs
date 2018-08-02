namespace CaravanInstructor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.attribute")]
    public partial class attribute
    {
        [Key]
        public int attribute_id { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        public int data_type_id { get; set; }

        public virtual data_type data_type { get; set; }
    }
}

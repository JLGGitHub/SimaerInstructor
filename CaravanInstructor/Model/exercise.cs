namespace CaravanInstructor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.exercise")]
    public partial class exercise
    {
        [Key]
        public int exercise_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime start_time { get; set; }

        [Column(TypeName = "date")]
        public DateTime? end_time { get; set; }

        public string instructor_comment { get; set; }

        public int procedure_id { get; set; }

        public bool approved { get; set; }

        public int report_id { get; set; }

        public virtual procedure procedure { get; set; }

        public virtual report report { get; set; }
    }
}

namespace CaravanInstructor.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbSimaer : DbContext
    {
        public DbSimaer()
            : base("name=DbSimaer")
        {
        }

        public virtual DbSet<action> action { get; set; }
        public virtual DbSet<attribute> attribute { get; set; }
        public virtual DbSet<data_type> data_type { get; set; }
        public virtual DbSet<exercise> exercise { get; set; }
        public virtual DbSet<grade> grade { get; set; }
        public virtual DbSet<pilot> pilot { get; set; }
        public virtual DbSet<procedure> procedure { get; set; }
        public virtual DbSet<procedure_type> procedure_type { get; set; }
        public virtual DbSet<report> report { get; set; }
        public virtual DbSet<runway_tol> runway_tol { get; set; }
        public virtual DbSet<scenario> scenario { get; set; }
        public virtual DbSet<system> system { get; set; }
        public virtual DbSet<time_day> time_day { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<action>()
                .HasMany(e => e.procedure)
                .WithRequired(e => e.action)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<data_type>()
                .HasMany(e => e.action)
                .WithRequired(e => e.data_type)
                .HasForeignKey(e => e.data_type_1_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<data_type>()
                .HasMany(e => e.action1)
                .WithOptional(e => e.data_type1)
                .HasForeignKey(e => e.data_type_2_id);

            modelBuilder.Entity<data_type>()
                .HasMany(e => e.attribute)
                .WithRequired(e => e.data_type)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<grade>()
                .HasMany(e => e.pilot)
                .WithRequired(e => e.grade)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<pilot>()
                .HasMany(e => e.report)
                .WithRequired(e => e.pilot)
                .HasForeignKey(e => e.instructor_code)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<pilot>()
                .HasMany(e => e.report1)
                .WithRequired(e => e.pilot1)
                .HasForeignKey(e => e.student_code)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<procedure>()
                .HasMany(e => e.exercise)
                .WithRequired(e => e.procedure)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<procedure_type>()
                .HasMany(e => e.procedure)
                .WithRequired(e => e.procedure_type)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<report>()
                .HasMany(e => e.exercise)
                .WithRequired(e => e.report)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<runway_tol>()
                .HasMany(e => e.scenario)
                .WithRequired(e => e.runway_tol)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<scenario>()
                .HasMany(e => e.report)
                .WithRequired(e => e.scenario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<system>()
                .HasMany(e => e.procedure)
                .WithRequired(e => e.system)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<time_day>()
                .HasMany(e => e.scenario)
                .WithRequired(e => e.time_day)
                .WillCascadeOnDelete(false);
        }
    }
}

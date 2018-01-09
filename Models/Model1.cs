namespace WebApplication3.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=defaultconnection")
        {
        }

        public virtual DbSet<Table_1> Table_1 { get; set; }
        public virtual DbSet<Table_2> Table_2 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table_1>()
                .Property(e => e.cars)
                .IsFixedLength();

            modelBuilder.Entity<Table_1>()
                .Property(e => e.bike)
                .IsFixedLength();

            modelBuilder.Entity<Table_1>()
                .HasMany(e => e.Table_2)
                .WithRequired(e => e.Table_1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Table_2>()
                .Property(e => e.carss)
                .IsFixedLength();

            modelBuilder.Entity<Table_2>()
                .Property(e => e.bikee)
                .IsFixedLength();
        }
    }
}

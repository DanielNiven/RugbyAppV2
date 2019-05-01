namespace RugbyApp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=AppDbContext")
        { }
             public DbSet<Juniors.JuniorsDetails> Juniors { get; set; }
        public DbSet<Juniors.ParentsDetails> Parents { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
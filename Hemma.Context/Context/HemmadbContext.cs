using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;
using System.Configuration;
using Hemma.Entities.Entities;

namespace Hemma.Context.Context
{
   public class HemmadbContext : DbContext
    {
        public DbSet<Person> Person { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(ConfigurationManager.ConnectionStrings["HemmaDb"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.firstname).IsRequired();
                entity.Property(e => e.lastname).IsRequired();
            });
        }
    }
}

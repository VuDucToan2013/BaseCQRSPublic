using Domain.Configuration;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SampleNetCoreAPIContext : DbContext
    {
        public SampleNetCoreAPIContext(DbContextOptions<SampleNetCoreAPIContext> options) : base(options)
        { }
        public SampleNetCoreAPIContext()
        {
        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.Entity<Product>().HasOne<Category>(s => s.Category).WithMany(g => g.Products).HasForeignKey(s => s.CategoryId);
        }
    }
}

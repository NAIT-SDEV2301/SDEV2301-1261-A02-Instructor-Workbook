using Microsoft.EntityFrameworkCore;
using Sdev2301.Lesson18.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sdev2301.Lesson18.Core.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Product> Products => Set<Product>();

        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);

            // TODO (after break): Explicitly configure Category and Product.
                        
            // Optional: restrict deletion of a Category with Products.
            model.Entity<Product>(entity =>
            {
                // 1. HasKey for both entities.
                entity.HasKey(p => p.Id);
                // 3. Product.Sku required/max 20 and Name required/max 100.
                entity.Property(p => p.Sku)
                      .IsRequired().HasMaxLength(20);
                entity.Property(p => p.Name)
                      .IsRequired().HasMaxLength(100);
                // 4. Unique index for Product.Sku.
                entity.HasIndex(p => p.Sku).IsUnique();
            });

            // 2. Category.Name required, max 50 characters.
            model.Entity<Category>(entity =>
            {
                entity.Property(c => c.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            // 5. HasOne/WithMany/HasForeignKey for CategoryId.
            model.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }

}

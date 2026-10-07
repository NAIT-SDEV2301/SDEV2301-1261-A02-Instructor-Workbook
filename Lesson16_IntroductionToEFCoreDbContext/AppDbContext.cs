using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Lesson16_IntroductionToEFCoreDbContext
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products => Set<Product>();

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var dbPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "..", "..", "..", "app.db");
            dbPath = Path.GetFullPath(dbPath);
            options.UseSqlite($"Data Source={dbPath}");
            
        }

    }
}

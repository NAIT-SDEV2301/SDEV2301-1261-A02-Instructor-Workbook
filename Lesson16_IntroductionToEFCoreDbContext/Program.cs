using Lesson16_IntroductionToEFCoreDbContext;
using Microsoft.EntityFrameworkCore.Storage;

using var context = new AppDbContext();
context.Database.EnsureCreated();

Console.WriteLine("Database ready.");

if (!context.Products.Any())
{
    context.Products.AddRange(
        new Product { Name = "Keyboad", Price = 49.99m },
        new Product { Name = "Mouse", Price = 24.99m },
        new Product { Name = "Monitor", Price = 219.99m }
        );

    var rowsSaved = context.SaveChanges();
    Console.WriteLine($"{rowsSaved} rows saved.");
}

var products = context.Products
    .OrderBy(p => p.Price)
    .ToList();
// Print each Product name and price
Console.WriteLine("Products listing");
foreach (var p in products)
{
    Console.WriteLine($"Name:{p.Name}, Price:{p.Price:C}");
}
var productsUnder50 = context.Products
    .Where(p => p.Price < 50)
    .OrderByDescending(p => p.Price)
    .ToList();
Console.WriteLine("Products under $50 sorted descending");
foreach (var p in productsUnder50)
{
    Console.WriteLine($"Name:{p.Name}, Price:{p.Price:C}");
}


using Lesson16_IntroductionToEFCoreDbContext;

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
}

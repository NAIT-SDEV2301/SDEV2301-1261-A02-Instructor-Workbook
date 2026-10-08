using Lesson17_EFCoreCRUDRelationships;
using Microsoft.EntityFrameworkCore;

using var context = new AppDbContext();
if (!context.Categories.Any())
{
    var category = new Category { Name = "Electronics" };
    category.Products.Add(new Product { Name = "Keyboard", Price = 49.99m });
    category.Products.Add(new Product { Name = "Mouse", Price = 24.99m });
    context.Categories.Add(category);
    context.SaveChanges();
    Console.WriteLine("Category and product seed data added");
}

var category1 = context.Categories
    .Include(c => c.Products)
    .First();
Console.WriteLine(category1.Name);
foreach (var product in category1.Products)
{
    Console.WriteLine($"- {product.Name}: {product.Price:C}");
}

var keyboard = context.Products.First(p => p.Name == "Keyboard");
keyboard.Price = 39.99m;
context.SaveChanges();

var electronics = context.Categories.First(c => c.Name == "Electronics");
context.Remove(electronics);
context.SaveChanges();

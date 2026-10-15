using Sdev2301.Lesson18.Core.Data;
using Sdev2301.Lesson18.Core.Entities;

namespace Sdev2301.Lesson18.Core.Services
{
    public class ProductService
    {
        private readonly AppDbContext _context;

        public ProductService(AppDbContext context)
        {
            _context = context;
        }

        public List<Product> GetActiveProducts()
        {
            // TODO 1: Filter to active products, sort by Name, return a List.
            return _context.Products
                .Where(p => p.IsActive)
                .OrderBy(p => p.Name)
                .ToList();
        }

        public Product CreateProduct(string sku, string name, decimal price, int categoryId)
        {
            // TODO 2: Reject blank SKU/name and price <= 0.
            if (string.IsNullOrWhiteSpace(sku))
            {
                throw new ArgumentNullException(nameof(sku), "SKU is required");
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(sku), "Name is required");
            }
            if (price <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(price), "Price must be positive");
            }
            // TODO 3: Reject a missing Category and duplicate SKU.
            if (!_context.Categories.Any(c => c.Id == categoryId))
            {
                throw new InvalidOperationException("Category does not exist.");
            }
            if (!_context.Products.Any(p => p.Sku == sku))
            {
                throw new InvalidOperationException($"Duplicate SKU {sku}");
            }
            // TODO 4: Build a Product, Add it, SaveChanges, return it.
            var newProduct = new Product
            {
                Name = name,
                Sku = sku,
                Price = price,
                CategoryId = categoryId,
                IsActive = true
            };
            _context.Products.Add(newProduct);
            _context.SaveChanges();
            return newProduct;
        }

        // Optional independent extension after completing today's core work.
        public void DeactivateProduct(int productId)
        {
            // Optional TODO: Find Product; set IsActive=false; SaveChanges.
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson17_EFCoreCRUDRelationships
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson16_IntroductionToEFCoreDbContext
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }

    }
}

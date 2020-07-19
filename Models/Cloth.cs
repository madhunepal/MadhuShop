using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadhuShop.Models
{
    public class Cloth
    {
        public int ClothId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageThumbNailUrl { get; set; }
        public string ImageUrl { get; set; }

        public bool IsOnSale { get; set; }
        public bool IsOnStock { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}

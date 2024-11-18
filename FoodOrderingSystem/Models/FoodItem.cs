using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Models
{
    class FoodItem
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public DateTime ExpiryDate { get; set; }

        public FoodItem(string name, string category, decimal price, DateTime expiryDate)
        {
            Name = name;
            Category = category;
            Price = price;
            ExpiryDate = expiryDate;
        }
    }
}

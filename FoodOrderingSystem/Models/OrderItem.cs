﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Models
{
    class OrderItem
    {
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; private set; }

        public OrderItem(int itemId, int quantity, decimal unitPrice)
        {
            ItemId = itemId;
            Quantity = quantity;
            UnitPrice = unitPrice;
            
        }
    }
}

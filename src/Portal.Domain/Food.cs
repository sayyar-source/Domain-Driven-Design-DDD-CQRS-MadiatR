using Portal.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain
{
    public class Food:BaseEntity
    {
      
        public int Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public FoodType FoodType { get; set; }
    }
}

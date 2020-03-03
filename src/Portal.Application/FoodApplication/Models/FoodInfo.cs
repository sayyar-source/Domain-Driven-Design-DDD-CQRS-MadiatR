using Portal.Common.Enums;
using System;

namespace Portal.Application.Foods.Models
{
    public class FoodInfo
    {
        public Guid ID { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public FoodType FoodType { get; set; }
    }
}

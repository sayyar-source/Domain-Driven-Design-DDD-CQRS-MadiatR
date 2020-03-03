using Portal.Common.Enums;
using System;

namespace Portal.Application.Foods.Models
{
    public class FoodEditInfo
    {
        public Guid Id { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public FoodType FoodType { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Portal.Domain
{
    public class OrderItem:BaseEntity
    {
 
        public Guid FoodId { get; set; }
        public int Count { get; set; }
        public int UnitPrice { get; set; }
        public int TotalPrice { get; set; }
        [ForeignKey("FoodId")]
        public  Food Foods { get; set; }
    }
}

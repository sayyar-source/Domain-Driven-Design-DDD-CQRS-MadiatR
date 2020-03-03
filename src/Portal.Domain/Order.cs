
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Portal.Domain
{

    public class Order:BaseEntity
    {
     
        public Guid UserId { get; set; }
        public OrderState State { get; set; }
        [ForeignKey("UserId")]
        public User Users { get; set; }
        public ICollection<OrderItem> Items { get; set; }
    }
}

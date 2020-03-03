using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Portal.Domain
{
    public class BaseEntity
    {
        [Key]
        public Guid ID { get; set; }
        public DateTime TimeCreated { get; set; }
        public bool IsEnable { get; set; }

    }
}

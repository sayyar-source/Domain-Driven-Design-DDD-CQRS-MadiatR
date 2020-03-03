using MediatR;
using Portal.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Application.FoodApplication.Commands.Create
{
   public class FoodCreateCommand:IRequest<Guid>
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public FoodType FoodType { get; set; }
    }
}

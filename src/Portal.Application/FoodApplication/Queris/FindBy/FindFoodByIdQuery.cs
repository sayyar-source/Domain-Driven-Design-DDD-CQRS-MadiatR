using MediatR;
using Portal.Application.Foods.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Application.FoodApplication.Queris.FindBy
{
   public class FindFoodByIdQuery:IRequest<FoodInfo>
    {
        public Guid ID { get; set; }
    }
}

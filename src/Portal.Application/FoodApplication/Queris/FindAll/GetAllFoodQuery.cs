using MediatR;
using Portal.Application.Foods.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Application.FoodApplication.Queris.FindAll
{
   public class GetAllFoodQuery:IRequest<IList<FoodInfo>>
    {
    }
}

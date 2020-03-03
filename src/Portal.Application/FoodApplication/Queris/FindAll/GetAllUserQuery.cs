using MediatR;
using Portal.Application.FoodApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Application.FoodApplication.Queris.FindAll
{
   public class GetAllUserQuery:IRequest<IList<UserInfo>>
    {
    }
}

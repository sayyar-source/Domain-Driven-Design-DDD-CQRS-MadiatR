using MediatR;
using Portal.Application.FoodApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Application.FoodApplication.Queris.FindBy
{
   public class FindUserByUsernameQuery:IRequest<UserInfo>
    {
        public string Username { get; set; }
    }
}

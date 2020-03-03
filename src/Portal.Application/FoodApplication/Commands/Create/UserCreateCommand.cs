using MediatR;
using Portal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Application.FoodApplication.Commands.Create
{
   public class UserCreateCommand:IRequest<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
       // public Address Address { get; set; }
    }
}

using AutoMapper;
using Portal.Application.FoodApplication.Models;
using Portal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Application.FoodApplication.Mapper
{
   public class UserMapper:Profile
    {
        public UserMapper()
        {
            CreateMap<User, UserInfo>();
        }
    }
}

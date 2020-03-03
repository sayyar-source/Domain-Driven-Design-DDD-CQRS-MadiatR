using FluentValidation;
using Portal.Application.FoodApplication.Commands.Create;
using Portal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Application.FoodApplication.Validation
{
   public class UserCreateCommandValidation:AbstractValidator<UserCreateCommand>
    {
        public UserCreateCommandValidation()
        {
            RuleFor(u => u.Email).EmailAddress().WithMessage("Email not is valid");
            RuleFor(u => u.UserName).NotEmpty().WithMessage("username not be null");
            RuleFor(u => u.Password).MinimumLength(3).WithMessage("password length shuld big than 3 character");
            //RuleFor(u => u.Address).SetValidator(new AddressValidetor());

        }
    }
    //public class AddressValidetor:AbstractValidator<Address>
    //{
    //    public AddressValidetor()
    //    {
    //        RuleFor(a => a.Postcode).NotNull().WithMessage("post code will not null ");
    //        //etc
    //    }
    //}
}

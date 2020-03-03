using FluentValidation;
using Portal.Application.FoodApplication.Commands.Create;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Application.FoodApplication.Validation
{
   public class FoodCreateCommandValidator:AbstractValidator<FoodCreateCommand>
    {
        public FoodCreateCommandValidator()
        {
            RuleFor(f => f.Price).GreaterThan(0).WithMessage("the price must big than 0");
            RuleFor(f => f.Name).NotEmpty().WithMessage("the name but not empty");
            RuleFor(f => f.Description).MaximumLength(20).WithMessage("the discription length not big than 10 charatcer");
        }
    }
}

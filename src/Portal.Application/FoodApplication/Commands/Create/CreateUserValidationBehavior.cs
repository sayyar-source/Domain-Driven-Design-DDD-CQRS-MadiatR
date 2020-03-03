using MediatR;
using Portal.Application.FoodApplication.Validation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portal.Application.FoodApplication.Commands.Create
{
    public class CreateUserValidationBehavior<TRequest, TResult> : IPipelineBehavior<UserCreateCommand, int>
    {
        public async Task<int> Handle(UserCreateCommand request, CancellationToken cancellationToken, RequestHandlerDelegate<int> next)
        {
            var validator = new UserCreateCommandValidation();
            var check = validator.Validate(request);
            if (check.IsValid)
            {
                var Response = await next();
                return Response;
            }
            else
            {
                string error = "";
                foreach (var item in check.Errors)
                {
                    error = error + "Property " + item.PropertyName + " failed validation. Error was: " + item.ErrorMessage + " /n";
                }
                throw new Exception(error);
            }
        }
    }
}

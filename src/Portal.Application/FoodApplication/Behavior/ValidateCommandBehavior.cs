using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portal.Application.FoodApplication.Behavior
{
    public class ValidateCommandBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
      where TRequest:IRequest<TResponse> 
    {
       // private readonly IList<IValidator<TRequest>> _validators;
        private readonly IEnumerable<IValidator<TRequest>> _validators;
        public ValidateCommandBehavior(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }
        public Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            var context =new  ValidationContext(request);
            var errors = _validators
             .Select(validator => validator.Validate(context))
             .SelectMany(result => result.Errors)
             .Where(error => error != null)
             .ToList();
            if (errors.Any())
            {
                var errorBiulder = new StringBuilder();
                errorBiulder.AppendLine("Invalid command, reason: ");
                foreach (var error in errors)
                {
                    errorBiulder.AppendLine(error.ErrorMessage);
                }
                throw new Exception(errorBiulder.ToString());

            }
            return next();
        }
    }
}

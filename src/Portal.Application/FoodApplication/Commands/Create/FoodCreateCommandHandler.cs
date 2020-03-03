using MediatR;
using Portal.Application.FoodApplication.Validation;
using Portal.Domain;
using Portal.Persisatance;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portal.Application.FoodApplication.Commands.Create
{
    public class FoodCreateCommandHandler : IRequestHandler<FoodCreateCommand, Guid>
    {
        private readonly PortalDbContext _db;
        public FoodCreateCommandHandler(PortalDbContext db)
        {
            _db = db;
        }

        public async Task<Guid> Handle(FoodCreateCommand request, CancellationToken cancellationToken)
        {
            try
            {
            
               
                    var food = new Food
                    {
                        Description = request.Description,
                        FoodType = request.FoodType,
                        Name = request.Name,
                        Price = request.Price
                    };
                    var result = _db.Foods.Add(food);
                    await _db.SaveChangesAsync();
                    return result.Entity.ID;
               
               
               
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}

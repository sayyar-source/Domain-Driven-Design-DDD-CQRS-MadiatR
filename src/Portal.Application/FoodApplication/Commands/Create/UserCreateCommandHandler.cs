using AutoMapper;
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
    public class UserCreateCommandHandler : IRequestHandler<UserCreateCommand, int>
    {
        private readonly PortalDbContext _db;
        private readonly IMapper _mapper;
        public UserCreateCommandHandler(PortalDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<int> Handle(UserCreateCommand request, CancellationToken cancellationToken)
        {
            try
            {
               
                    var user = new User()
                    {
                        Email = request.Email,
                        FirstName = request.FirstName,
                        IsEnable = true,
                        LastName = request.LastName,
                        Password = request.Password,
                        Phone = request.Phone,
                        UserName = request.UserName,
                        TimeCreated = DateTime.Now
                    };
                    _db.Users.Add(user);
                    var result = await _db.SaveChangesAsync();
                    return result;
                
               

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}

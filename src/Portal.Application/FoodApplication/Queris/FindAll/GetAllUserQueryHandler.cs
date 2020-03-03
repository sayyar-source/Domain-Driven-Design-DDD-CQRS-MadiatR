using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Portal.Application.FoodApplication.Models;
using Portal.Domain;
using Portal.Persisatance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portal.Application.FoodApplication.Queris.FindAll
{
    public class GetAllUserQueryHandler : IRequestHandler<GetAllUserQuery, IList<UserInfo>>
    {
        private readonly PortalDbContext _db;
        private readonly IMapper _mapper;
        public GetAllUserQueryHandler(PortalDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<IList<UserInfo>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var model = _db.Users.ToList();
                return model.Select(_mapper.Map<User, UserInfo>).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

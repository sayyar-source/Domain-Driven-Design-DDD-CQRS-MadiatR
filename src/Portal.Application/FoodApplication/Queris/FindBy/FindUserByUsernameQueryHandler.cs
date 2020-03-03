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

namespace Portal.Application.FoodApplication.Queris.FindBy
{
    public class FindUserByUsernameQueryHandler : IRequestHandler<FindUserByUsernameQuery, UserInfo>
    {
        private readonly PortalDbContext _db;
        private readonly IMapper _mapper;
        public FindUserByUsernameQueryHandler(PortalDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<UserInfo> Handle(FindUserByUsernameQuery request, CancellationToken cancellationToken)
        {
            var model = await _db.Users.Where(u => u.UserName == request.Username).FirstOrDefaultAsync();
            return _mapper.Map<User, UserInfo>(model);
        }
    }
}

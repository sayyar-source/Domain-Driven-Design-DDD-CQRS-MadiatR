using AutoMapper;
using MediatR;
using Portal.Application.FoodApplication.Models;
using Portal.Application.Foods.Models;
using Portal.Domain;
using Portal.Persisatance;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portal.Application.FoodApplication.Queris.FindBy
{
    public class FindFoodByIdQueryHandler : IRequestHandler<FindFoodByIdQuery, FoodInfo>
    {
        private readonly PortalDbContext _db;
        private readonly IMapper _mapper;
        public FindFoodByIdQueryHandler(PortalDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<FoodInfo> Handle(FindFoodByIdQuery request, CancellationToken cancellationToken)
        {
            var model =await _db.Foods.FindAsync(request.ID);
            return _mapper.Map<Food, FoodInfo>(model);
        }
    }
}

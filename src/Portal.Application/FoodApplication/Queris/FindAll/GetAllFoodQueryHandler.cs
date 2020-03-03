using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Portal.Application.Foods.Models;
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
    public class GetAllFoodQueryHandler : IRequestHandler<GetAllFoodQuery, IList<FoodInfo>>
    {
        private readonly PortalDbContext _db;
        private readonly IMapper _mapper;
        public GetAllFoodQueryHandler(PortalDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<IList<FoodInfo>> Handle(GetAllFoodQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var model = await _db.Foods.ToListAsync();
                return model.Select(_mapper.Map<Food, FoodInfo>).ToList();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

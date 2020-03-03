using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Portal.Application.Foods.Models;

namespace Portal.Application.Foods
{
    public interface IFoodService
    {
        Task Create(FoodAddInfo info);
        Task<FoodInfo> FindById(Guid id);
        Task<IList<FoodInfo>> FindAll();
        Task<FoodEditInfo> GetEdit(Guid foodId);
        Task Update(FoodEditInfo foodEditInfo);
    }
}
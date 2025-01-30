using Server.Core.Entities;
using Server.Core.Services.ResultModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Core.Services.Interfaces
{
    public interface IShoeService
    {
        IQueryable<Shoe> GetAll();
        Task<ResultModel<IEnumerable<Shoe>>> ListAllShoesAsync();
        Task<ResultModel<Shoe>> GetShoeById(int shoeId);
        Task<ResultModel<IEnumerable<Shoe>>> FilterListShoesAsync(int? categoryId, int? brandId, decimal? minPrice, decimal? maxPrice, int? size, string? name);

    }
}

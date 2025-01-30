using Server.Core.Entities;
using Server.Core.Services.ResultModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Core.Services.Interfaces
{
    public interface IShoeBrandService
    {
        IQueryable<ShoeBrand> GetAllBrands();
        Task<ResultModel<IEnumerable<ShoeBrand>>> GetShoeBrandsAsync();
    }
}

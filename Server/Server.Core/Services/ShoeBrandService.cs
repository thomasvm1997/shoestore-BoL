using Microsoft.EntityFrameworkCore;
using Server.Core.Data;
using Server.Core.Entities;
using Server.Core.Services.Interfaces;
using Server.Core.Services.ResultModels;

namespace Server.Core.Services
{
    public class ShoeBrandService : IShoeBrandService
    {
        public ApplicationDbContext _db;

        public ShoeBrandService(ApplicationDbContext db)
        {
            _db = db;
        }
        public IQueryable<ShoeBrand> GetAllBrands()
        {
            return _db.Brands.Include(p => p.Shoes);
        }

        public async Task<ResultModel<IEnumerable<ShoeBrand>>> GetShoeBrandsAsync()
        {
            var list = await GetAllBrands().ToListAsync();

            if (list.Count == 0)
            {
                return new ResultModel<IEnumerable<ShoeBrand>> { Errors = new List<string> { "Could not find Brands" } };
            }

            
            return new ResultModel<IEnumerable<ShoeBrand>> { Data = list };
        }
    }
}

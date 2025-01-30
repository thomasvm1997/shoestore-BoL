using Microsoft.EntityFrameworkCore;
using Server.Core.Data;
using Server.Core.Entities;
using Server.Core.Services.Interfaces;
using Server.Core.Services.ResultModels;

namespace Server.Core.Services
{
    public class ShoeCategoryService : IShoeCategoryService
    {
        public ApplicationDbContext _db;
        public ShoeCategoryService(ApplicationDbContext db)
        {
            _db = db;
        }
        public IQueryable<ShoeCategory> GetAllCategories()
        {
            return _db.Categories.Include(p => p.Shoes);
        }

        public async Task<ResultModel<IEnumerable<ShoeCategory>>> GetShoeCategoriesAsync()
        {
            var list = await GetAllCategories().ToListAsync();

            if (list.Count == 0)
            {
                return new ResultModel<IEnumerable<ShoeCategory>> { Errors = new List<string> { "Could not find Categories" } };
            }

            
            return new ResultModel<IEnumerable<ShoeCategory>> { Data = list };
        }

    }
}

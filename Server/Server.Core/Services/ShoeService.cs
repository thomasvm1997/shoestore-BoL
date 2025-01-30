using Microsoft.EntityFrameworkCore;
using Server.Core.Data;
using Server.Core.Entities;
using Server.Core.Services.Interfaces;
using Server.Core.Services.ResultModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Core.Services
{
    public class ShoeService : IShoeService
    {
        public ApplicationDbContext _db;
        public ShoeService(ApplicationDbContext db)
        {
            _db = db;
        }
        public IQueryable<Shoe> GetAll()
        {
            return _db.Shoes.Include(p => p.ShoeBrand).Include(c => c.ShoeCategory);
        }
        public async Task<ResultModel<Shoe>> GetShoeById(int shoeId)
        {
            var list = await GetAll().ToListAsync();
            if (list.Count == 0)
            {
                return new ResultModel<Shoe> { Errors = new List<string> { "Could not find shoes" } };
            }
            var shoe = list.Where(c => c.Id == shoeId).FirstOrDefault();
            if(shoe == null)
            {
                return new ResultModel<Shoe> { Errors = new List<string> { "Could not find shoe" } };
            }
            return new ResultModel<Shoe> { Data = shoe };
        }

        public async Task<ResultModel<IEnumerable<Shoe>>> ListAllShoesAsync()
        {
            var list = await GetAll().ToListAsync();
            if (list.Count == 0)
            {
                return new ResultModel<IEnumerable<Shoe>> { Errors = new List<string> { "Could not find shoes" } };
            }

            return new ResultModel<IEnumerable<Shoe>> { Data = list };
        }

        public async Task<ResultModel<IEnumerable<Shoe>>> FilterListShoesAsync(int? categoryId, int? brandId, decimal? minPrice, decimal? maxPrice, int? size, string? name)
        {
            var list = await GetAll().ToListAsync();


            if (list.Count == 0)
            {
                return new ResultModel<IEnumerable<Shoe>> { Errors = new List<string> { "Could not find shoes" } };
            }

            var filteredList = list.Where(shoe =>
                                (!categoryId.HasValue || shoe.ShoeCategoryId == categoryId.Value) && // !.HasValue => Als param null is => returned true => filter wordt genegeerd
                                (!brandId.HasValue || shoe.ShoeBrandId == brandId.Value) &&
                                (!minPrice.HasValue || shoe.Price >= minPrice.Value) &&
                                (!maxPrice.HasValue || shoe.Price <= maxPrice.Value) &&
                                (!size.HasValue || shoe.Size == size.Value) &&
                                (string.IsNullOrEmpty(name) || shoe.Name.Contains(name, StringComparison.OrdinalIgnoreCase))).ToList();

            if (!filteredList.Any())
            {
                return new ResultModel<IEnumerable<Shoe>> { Errors = new List<string> { "No shoes match the filter criteria" } };
            }

            return new ResultModel<IEnumerable<Shoe>> { Data = filteredList };

        }

    }
}

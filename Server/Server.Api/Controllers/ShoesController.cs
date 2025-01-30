using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Server.Api.Dtos;
using Server.Core.Services.Interfaces;

namespace Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoesController : ControllerBase
    {
        private readonly IShoeService _shoeService;

        public ShoesController(IShoeService shoeService)
        {
            _shoeService = shoeService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _shoeService.ListAllShoesAsync();

            if (result.Success)
            {
                var listDto = result.Data.Select(c => new ShoeDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description,
                    Size = c.Size,
                    ImageUrl = c.ImageUrl,
                    Price = c.Price,
                    ShoeBrandId = c.ShoeBrandId,
                    ShoeBrandName = c.ShoeBrand.Name,
                    ShoeCategoryId = c.ShoeCategoryId,
                    ShoeCategoryName = c.ShoeCategory.Name
                }).ToList();

                return Ok(listDto);
            }
            return BadRequest(result.Errors);
        }
        [HttpGet("{shoeId}")]
        public async Task<IActionResult> GetById(int shoeId)
        {
            var result = await _shoeService.GetShoeById(shoeId);

            if (result.Success)
            {
                var shoeDto = new ShoeDto
                {
                    Id = result.Data.Id,
                    Name = result.Data.Name,
                    Description = result.Data.Description,
                    Size = result.Data.Size,
                    ImageUrl = result.Data.ImageUrl,
                    Price = result.Data.Price,
                    ShoeBrandId = result.Data.ShoeBrandId,
                    ShoeBrandName = result.Data.ShoeBrand.Name,
                    ShoeCategoryId = result.Data.ShoeCategoryId,
                    ShoeCategoryName = result.Data.ShoeCategory.Name
                };

                return Ok(shoeDto);
            }
            return BadRequest(result.Errors);
        }
        [HttpGet("filter")]
        public async Task<IActionResult> GetFilteredShoeList(
                        [FromQuery] int? categoryId,
                        [FromQuery] int? brandId,
                        [FromQuery] decimal? minPrice,
                        [FromQuery] decimal? maxPrice,
                        [FromQuery] int? size,
                        [FromQuery] string? name)
        {
            var result = await _shoeService.FilterListShoesAsync(categoryId, brandId, minPrice, maxPrice, size, name);

            if (result.Success)
            {
                var listDto = result.Data.Select(c => new ShoeDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description,
                    Size = c.Size,
                    ImageUrl = c.ImageUrl,
                    Price = c.Price,
                    ShoeBrandId = c.ShoeBrandId,
                    ShoeBrandName = c.ShoeBrand.Name,
                    ShoeCategoryId = c.ShoeCategoryId,
                    ShoeCategoryName = c.ShoeCategory.Name
                }).ToList();

                return Ok(listDto);
            }

            return BadRequest(result.Errors);
        }
    }
}

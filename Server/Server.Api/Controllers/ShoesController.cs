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
    }
}

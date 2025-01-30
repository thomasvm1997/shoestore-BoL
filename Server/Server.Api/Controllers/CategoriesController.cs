using Microsoft.AspNetCore.Mvc;
using Server.Api.Dtos;
using Server.Core.Services;
using Server.Core.Services.Interfaces;

namespace Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IShoeCategoryService _shoeCategoryService;
        public CategoriesController(IShoeCategoryService shoeCategoryService)
        {
            _shoeCategoryService = shoeCategoryService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _shoeCategoryService.GetShoeCategoriesAsync();

            if (result.Success)
            {
                var listDto = result.Data.Select(c => new ShoeCategoryDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description,
                }).ToList();

                return Ok(listDto);
            }
            return BadRequest(result.Errors);
        }
    }
}

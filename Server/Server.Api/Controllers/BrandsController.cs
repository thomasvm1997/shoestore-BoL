using Microsoft.AspNetCore.Mvc;
using Server.Api.Dtos;
using Server.Core.Services.Interfaces;

namespace Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IShoeBrandService _shoeBrandService;
        public BrandsController(IShoeBrandService shoeBrandService)
        {
            _shoeBrandService = shoeBrandService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _shoeBrandService.GetShoeBrandsAsync();

            if(result.Success)
            {
                var listDto = result.Data.Select(c => new ShoeBrandDto
                {
                    Id = c.Id,
                    Name = c.Name,
                }).ToList();

                return Ok(listDto);
            }
            return BadRequest(result.Errors);
        }
    }
}

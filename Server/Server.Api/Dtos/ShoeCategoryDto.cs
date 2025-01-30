
using System.ComponentModel.DataAnnotations;

namespace Server.Api.Dtos
{
    public class ShoeCategoryDto : BaseDto
    {
        [Required]
        public string Description { get; set; }
    }

}

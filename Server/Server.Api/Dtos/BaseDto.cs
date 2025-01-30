
using System.ComponentModel.DataAnnotations;

namespace Server.Api.Dtos
{
    public abstract class BaseDto
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Id must be a positive number.")]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }

}

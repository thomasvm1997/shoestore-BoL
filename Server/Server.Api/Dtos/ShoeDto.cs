
using System.ComponentModel.DataAnnotations;

namespace Server.Api.Dtos
{
    public class ShoeDto : BaseDto
    {
        [Required]
        public string Description { get; set; }
        [Required]
        [Range(0.01, 1000.00, ErrorMessage = "Price must be between 0.01 and 1000.00.")]
        public decimal Price { get; set; }
        [Required]
        [Range(36, 46, ErrorMessage = "Size must be between 36 and 46.")]
        public int Size { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "ShoeBrandId must be a positive number.")]
        public int ShoeBrandId { get; set; }
        [Required]
        public string ShoeBrandName { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "ShoeCategoryId must be a positive number.")]
        public int ShoeCategoryId { get; set; }
        [Required]
        public string ShoeCategoryName { get; set; }
    }

}

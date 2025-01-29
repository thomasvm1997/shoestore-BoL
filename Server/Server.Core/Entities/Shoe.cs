using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Core.Entities
{
    public class Shoe : BaseEnitity
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Size { get; set; }
        public string ImageUrl { get; set; }
        public int ShoeBrandId { get; set; }
        public ShoeBrand ShoeBrand { get; set; }
        public int ShoeCategoryId { get; set; }
        public ShoeCategory ShoeCategory { get; set; }
    }
}

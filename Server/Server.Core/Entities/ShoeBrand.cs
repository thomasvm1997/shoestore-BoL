using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Core.Entities
{
    public class ShoeBrand : BaseEnitity
    {
        public ICollection<Shoe> Shoes { get; set; }
    }
}

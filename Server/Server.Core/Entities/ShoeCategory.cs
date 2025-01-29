using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Core.Entities
{
    public class ShoeCategory : BaseEnitity
    {
        public string Description { get; set; }
        public ICollection<Shoe> Shoes { get; set; }
    }
}

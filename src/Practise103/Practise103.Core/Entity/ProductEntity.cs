using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise103.Core.Entity
{
    public class ProductEntity : EntityBase
    {
        public string Name { get; set; }
        public Decimal Price { get; set; }
        public int Stock { get; set; }
        public string UserId { get; set; }
    }
}

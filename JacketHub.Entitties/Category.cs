using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacketHub.Entitties
{
   public  class Category:BaseEntitties
    {
        public List<Product> Product { get; set; }
    }
}

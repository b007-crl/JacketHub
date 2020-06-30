using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacketHub.Entitties
{
   public class Product:BaseEntitties
    {
        public decimal Price { get; set; }
        public Category Category { get; set; }
    }
}

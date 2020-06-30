using JacketHub.Entitties;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacketHub.DataBase
{
   public class JHContext : DbContext,IDisposable
    {
        public JHContext() : base("JHConn")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> categories { get; set; }
    }
}

using JacketHub.DataBase;
using JacketHub.Entitties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace jacketHub.Services
{
    public class ProductServices
    {
        public List<Product> GetProducts()
        {
            using(var context = new JHContext())
            {
                return context.Products.ToList();
            }

        }

        public Product GetProduct(int ID)
        {
            using (var context = new JHContext())
            {
                return context.Products.Find(ID);
            }

        }

        public void SaveProduct(Product product)
        {
            using (var context = new JHContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }

        }

        public void UpdateProduct(Product product)
        {
            using (var context = new JHContext())
            {
                context.Entry(product).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteProduct(int ID)
        {
            using (var context = new JHContext())
            {
                var product = context.Products.Find(ID);
                context.Products.Remove(product);
                context.SaveChanges();
            }

        }

      
    } 
}

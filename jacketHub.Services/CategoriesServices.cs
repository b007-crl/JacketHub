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
    public class CategoriesServices
    {
        public List<Category> GetCategories()
        {
            using(var context = new JHContext())
            {
                return context.categories.ToList();
            }

        }

        public Category GetCategory(int ID)
        {
            using (var context = new JHContext())
            {
                return context.categories.Find(ID);
            }

        }

        public void SaveCategory(Category category)
        {
            using (var context = new JHContext())
            {
                context.categories.Add(category);
                context.SaveChanges();
            }

        }

        public void UpdateCategory(Category category)
        {
            using (var context = new JHContext())
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteCategory(int ID)
        {
            using (var context = new JHContext())
            {
                var category = context.categories.Find(ID);
                context.categories.Remove(category);
                context.SaveChanges();
            }

        }
    } 
}

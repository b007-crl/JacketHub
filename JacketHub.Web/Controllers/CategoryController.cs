using jacketHub.Services;
using JacketHub.Entitties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JacketHub.Web.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoriesServices services = new CategoriesServices();
        public ActionResult Index()
        {
            var categories = services.GetCategories(); 
            return View(categories);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category category)
        {
            services.SaveCategory(category);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int ID)
        {
            var category = services.GetCategory(ID);
            return View(category);
        }
        [HttpPost]
        public ActionResult Edit(Category category)
        {
           services.UpdateCategory(category);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int ID)
        {
            var category = services.GetCategory(ID);
            return View(category);
        }
        [HttpPost]
        public ActionResult Delete(Category category)
        {
            services.DeleteCategory(category.Id);

            return RedirectToAction("Index");
        }
    }
}
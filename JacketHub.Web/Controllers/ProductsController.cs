using jacketHub.Services;
using JacketHub.Entitties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JacketHub.Web.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        ProductServices services = new ProductServices();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductTable(string search)
        {
           var products =  services.GetProducts();
            if (!string.IsNullOrEmpty(search))
            {
                products = products.Where(p => p.Name != null && p.Name.ToLower().Contains(search.ToLower())).ToList();
            }
            
            return PartialView(products);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            services.SaveProduct(product);
            return RedirectToAction("Index");
        }
    }
}
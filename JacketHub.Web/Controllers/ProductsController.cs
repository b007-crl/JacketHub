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

        public ActionResult ProductTable()
        {
           var products =  services.GetProducts();
            return View(products);
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
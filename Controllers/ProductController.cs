using System;
using System.Collections.Generic;
using System.Web.Mvc;
using DataAcess.Context;
using DataAcess.Modell;
using Services.DatabaseAcess;

namespace StoreWebbsite_Frame.Controllers
{
    public class ProductController : Controller
    {
        public static ProductContext Products = new ProductContext();

        // GET: Product
        public ActionResult Index(GetProducts ProductContext)
        {
            try
            {
                List<ProductModell> loadedProducts = ProductContext.GetProduct();

                return View(loadedProducts);
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}

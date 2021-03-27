using System;
using System.Web.Mvc;
using DataAcess.Context;
using Services.DatabaseAcess.GetFromDatabase;

namespace StoreWebbsite_Frame.Controllers
{
    public class ProductController : Controller
    {
        public static ProductContext Products = new ProductContext();

        // GET: Product
        public ActionResult Index(IGetProduct ProductContext)
        {
            try
            {
                return View(ProductContext.GetProduct());
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

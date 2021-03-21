using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAcess;
using DataAcess.Modell;
using DataAcess.Context;
using System.Threading.Tasks;

namespace StoreWebbsite_Frame.Controllers
{
    public class ProductController : Controller
    {
        public static ProductContext Products = new ProductContext();

        // GET: Product
        public ActionResult Index()
        {
            List<ProductModell> loadedProducts = new List<ProductModell>();

            Task AsynGetStoreTask = Task.Run(() =>
            {
                try
                {
                    loadedProducts = (from Product in Products.Products select Product).ToList();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            });

            AsynGetStoreTask.Wait();

            return View(loadedProducts);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}

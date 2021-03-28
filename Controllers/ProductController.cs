using System;
using System.Collections.Generic;
using System.Web.Mvc;
using DataAcess.Context;
using DataAcess.Modell;
using Services.DatabaseAcess;
using Services.DatabaseAcess.GetFromDatabase;

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
        public ActionResult Details(Guid id, GetProducts ProductContext)
        {
            List<ProductModell> loadedProducts          = ProductContext.GetProduct();
            ProductModell loadedProducts2               = new ProductModell();

            foreach (ProductModell Modell in loadedProducts)
            {
                if(Modell.productID == id)
                {
                    loadedProducts2 = Modell;
                }
            }

            return View(loadedProducts2);
        }

        public ActionResult Reviews(Guid id)
        {
            GetReviewByProductID rt = new GetReviewByProductID();

            return View(rt.GetReviewByProductI(id));
        }
    }
}

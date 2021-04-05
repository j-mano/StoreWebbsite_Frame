using System;
using System.Collections.Generic;
using System.Web.Mvc;
using DataAcess.Context;
using DataAcess.Modell;
using Services.DatabaseAcess;
using Services.DatabaseAcess.GetFromDatabase;
using Services.DatabaseAcess.WriteToDatabase;

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

        [HttpGet]
        public ActionResult Reviews(Guid id, GetReviewByProductID rt)
        {
            return PartialView( rt.GetReviewByProductI(id) );
        }

        public ActionResult WriteReviews( Guid id, ProductReviewModell GetReviewDetails )
        {
            GetReviewDetails.ProductIDKey = id;

            return View(GetReviewDetails);
        }

        // POST: Default/Create
        [HttpPost]
        public async System.Threading.Tasks.Task<ActionResult> WriteReviews( ProductReviewModell Review , WriteReview DataBaseWriteReview)
        {
            try
            {
                bool succesfullywriten = await DataBaseWriteReview.createReviewAsync(Review);

                return RedirectToAction( "Details" , new { id = Review.ProductIDKey, UrlParameter.Optional } );
            }
            catch(Exception e)
            {
                return View();
            }
        }
    }
}

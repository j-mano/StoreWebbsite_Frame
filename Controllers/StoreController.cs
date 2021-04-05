using System;
using System.Web.Mvc;
using Services.DatabaseAcess;

namespace StoreWebbsite_Frame.Controllers
{
    public class StoreController : Controller
    {
        public static DataAcess.Context.StoreContext Stores = new DataAcess.Context.StoreContext();

        // GET: Store
        public ActionResult Index(GetStores storeContext)
        {
            try
            {
                return View(storeContext.getStores());
            }
            catch(Exception e)
            {
                return View();
            }
        }

        // GET: Store/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}

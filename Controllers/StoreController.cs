using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DataAcess.Modell;
using Services.DatabaseAcess;
using Services.DatabaseAcess.GetFromDatabase;

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

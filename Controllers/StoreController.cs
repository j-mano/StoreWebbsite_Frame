using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DataAcess.Modell;

namespace StoreWebbsite_Frame.Controllers
{
    public class StoreController : Controller
    {
        public static DataAcess.Context.StoreContext Stores = new DataAcess.Context.StoreContext();

        // GET: Store
        public ActionResult Index()
        {
            List<StoreModell> loadedStores= new List<StoreModell>();

            Task AsynGetStoreTask = Task.Run(() =>
            {
                try
                {
                   // loadedStores = (from Stores in Stores.StoreInfo select Stores).ToList();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            });

            AsynGetStoreTask.Wait();

            return View(loadedStores);
        }

        // GET: Store/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}

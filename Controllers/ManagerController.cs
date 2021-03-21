using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DataAcess.Context;
using DataAcess.Modell;
using static System.Data.Entity.Database;

namespace StoreWebbsite_Frame.Controllers
{
    public class ManagerController : Controller
    {
        public static ManagerContext ManagersControlls = new ManagerContext();

        // GET: Manager
        public ActionResult Index()
        {
            List<ManagerInfoModell> Managers = new List<ManagerInfoModell>();

            Task AsynGetStoreTask = Task.Run(() =>
            {
                try
                {
                    Managers = (from manager in ManagersControlls.ManagerInfo select manager).ToList();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            });

            AsynGetStoreTask.Wait();

            return View(Managers);
        }

        // GET: Manager/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}

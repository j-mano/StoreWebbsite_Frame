using System;
using System.Web.Mvc;
using DataAcess.Context;
using Services.DatabaseAcess;

namespace StoreWebbsite_Frame.Controllers
{
    public class ManagerController : Controller
    {
        public static ManagerContext ManagersControlls = new ManagerContext();

        // GET: Manager
        public ActionResult Index(GetManagers MangagerContext)
        {
            try
            {
                return View(MangagerContext.getManagers());
            }
            catch(Exception e)
            {
                return View();
            }
        }

        // GET: Manager/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}

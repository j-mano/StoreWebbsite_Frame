using Autofac;
using StoreWebbsite_Frame.aplication;
using StoreWebbsite_Frame.AutofaqConfig;
using System.Web.Mvc;

namespace StoreWebbsite_Frame.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
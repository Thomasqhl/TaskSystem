using System.Web.Mvc;

namespace SimpleTask.Web.Controllers
{
    public class AboutController : SimpleTaskControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
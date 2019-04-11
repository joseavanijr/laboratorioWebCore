using Microsoft.AspNetCore.Mvc;

namespace LaboratorioWebCore.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}
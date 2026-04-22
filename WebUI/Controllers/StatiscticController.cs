using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class StatiscticController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

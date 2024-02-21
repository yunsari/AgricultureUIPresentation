using Microsoft.AspNetCore.Mvc;

namespace AgricultureUIPresentation.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

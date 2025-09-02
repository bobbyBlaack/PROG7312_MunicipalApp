using Microsoft.AspNetCore.Mvc;

namespace Loyiso_Municipality.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

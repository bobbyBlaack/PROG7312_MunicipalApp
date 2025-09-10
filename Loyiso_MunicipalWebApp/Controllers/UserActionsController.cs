using Loyiso_MunicipalWebApp.Data;
using Loyiso_MunicipalWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Loyiso_MunicipalWebApp.Controllers
{
    public class UserActionsController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public UserActionsController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;

        }
        public IActionResult LocalNews()
        {
            return View();
        }

        public IActionResult ReportIssues()
        {
            return View();
        }

        public IActionResult ReportStatus()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewReport(ReportModel report)
        {


            _context.Add(report);
            _context.SaveChanges();
            return RedirectToAction("ReportIssues");

        }


    }
}

using Microsoft.AspNetCore.Mvc;
using SDMS.Models;
using System.Diagnostics;

namespace SDMS.Controllers
{
    //[Route("students")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SDMS.Data.ApplicationDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, SDMS.Data.ApplicationDbContext context)
        {
            _logger = logger;
            _dbContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Students()
        {
            var allStudents = _dbContext.Studnets.ToList();
            return View(allStudents);
        }

        public IActionResult CreateStudents() 
        {
            return View();
        }

        public IActionResult CreateStudentForm(Student model)
        {
            _dbContext.Studnets.Add(model);
            _dbContext.SaveChanges();

            return RedirectToAction("Students");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

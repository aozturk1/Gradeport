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
            var allStudents = _dbContext.Students.ToList();
            return View(allStudents);
        }

        public IActionResult DeleteStudent(int id) 
        {
            var studentInDb = _dbContext.Students.SingleOrDefault(s => s.Id == id);
            _dbContext.Students.Remove(studentInDb);
            _dbContext.SaveChanges();
            return RedirectToAction("Students");
        }

        public IActionResult CreateStudents(int? id) 
        {
            if(id != null) 
            {
                //edit
                var studentInDb = _dbContext.Students.SingleOrDefault(s => s.Id == id);
                return View(studentInDb);
            }
            return View();
        }

        public IActionResult CreateStudentForm(Student model)
        {
            if(model.Id == 0)
            {
                _dbContext.Students.Add(model);
            } 
            else
            {
                _dbContext.Students.Update(model);
            }
            
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

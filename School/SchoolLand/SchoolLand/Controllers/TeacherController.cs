using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchoolLand.Models;
using SchoolLand.Models.ViewModels;

namespace SchoolLand.Controllers
{
    public class TeacherController : Controller
    {

        private readonly DbslandContext _context;

        public TeacherController(DbslandContext context)
        {
            _context = context; 
        }
        public IActionResult CreateTeacher()
        {
            ViewData["Teachers"] = new SelectList(_context.Teachers, "IdTeacher", "NameTeacher", "Age", "Phone");
            return View();  
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateTeacher(TeacherViewModel models)
        {
            if (ModelState.IsValid)
            {
                var teacherReferences = new Teacher()
                {
                    NameTeacher = models.NameTeacher,
                    Phone = models.Phone,
                    Carnet = models.Carnet, 
                    Age = models.Age,
                    YearsSchool = models.YearsSchool,
                };
                _context.Add(teacherReferences);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Teachers"] = new SelectList(_context.Teachers, "IdTeacher", "NameTeacher", "Age", "Phone");
            return View(); 
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Teachers.ToListAsync());
        }
    }
}
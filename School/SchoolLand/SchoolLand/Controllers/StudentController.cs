using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchoolLand.Models;
using SchoolLand.Models.ViewModels;
using System.Diagnostics;

namespace SchoolLand.Controllers
{
    public class StudentController : Controller
    {
        private readonly DbslandContext _context;
        public StudentController(DbslandContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            ViewData["Student"] = new SelectList(_context.Students, "StudentId", "nameStudent", "lastName", "Carnet");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async  Task<IActionResult> Create(StudentsViewModels models)
        {
            if (ModelState.IsValid)
            {
                var student = new Student()
                {
                    NameStudent = models.NameStudent,
                    Lastname = models.Lastname,
                    Correo = models.Correo,
                    Carnet = models.Carnet,
                    Pass = models.Pass,
                };
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index)); 
            }
            ViewData["Student"] = new SelectList(_context.Students, "nameStudent", "Lastname", "Correo", "Carnet");
            return View();
        }
        public async  Task<IActionResult> Index()
        {
            return View(await _context.Students.ToListAsync()); 
        }

    }
}

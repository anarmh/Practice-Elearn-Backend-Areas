using Elearn.Data;
using Elearn.Models;
using Elearn.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Elearn.Controllers
{
    public class CoursesController : Controller
    {
        private readonly AppDbContext _context;
        public CoursesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Course> courses = await _context.Courses.Where(m => !m.SoftDelete).Include(m=>m.CourseImages).Include(m=>m.CourseAuthor).Take(3).ToListAsync();
            int count = await _context.Courses.Where(m => !m.SoftDelete).CountAsync();
            ViewBag.Count = count;
            return View(courses);
        }


        [HttpGet]
        public async Task<IActionResult> ShowMoreOrLess(int skip)
        {
            IEnumerable<Course> courses = await _context.Courses.Where(m => !m.SoftDelete).Skip(skip).Take(3).ToListAsync();
           
           
            return PartialView("_CoursePartial", courses);
        }
    }
}

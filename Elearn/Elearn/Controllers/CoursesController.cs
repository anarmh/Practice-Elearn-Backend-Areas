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
            IEnumerable<CourseAuthor> courseAuthors = await _context.CourseAuthors.Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<Course> courses = await _context.Courses.Include(m => m.CourseImages).Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<CourseImage> courseImages = await _context.CourseImages.Where(m => !m.SoftDelete).ToListAsync();

            CourseVM model = new()
            {
                CourseAuthors = courseAuthors,
                CourseImages = courseImages,
                Courses = courses
            };
            return View(model);
        }



        public async Task<IActionResult> ShowMoreOrLess()
        {
            return Ok();
        }
    }
}

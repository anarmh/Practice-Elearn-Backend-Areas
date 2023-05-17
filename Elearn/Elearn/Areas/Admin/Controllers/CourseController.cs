using Elearn.Areas.Admin.ViewModels.Course;
using Elearn.Areas.Admin.ViewModels.Slider;
using Elearn.Data;
using Elearn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Elearn.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CourseController : Controller
    {
       
        private readonly AppDbContext _context;

        public CourseController(AppDbContext context)
        {
            _context = context;
        }
       
        public async Task<IActionResult> Index()
        {
            List<CourseVM> listCourse = new();
            List<Course> courses =await _context.Courses.Include(m=>m.CourseImages).Include(m=>m.CourseAuthor).Where(m=>!m.SoftDelete).ToListAsync();
            foreach (var course in courses)
            {
                CourseVM model = new()
                {
                    Id = course.id,
                    Title = course.Title,
                    Description = course.Description,
                    Price= course.Price,
                    CourseAuthor=course.CourseAuthor,
                    CourseImages=course.CourseImages,
                };
                listCourse.Add(model);
            }
            return View(listCourse);
        }


        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            Course dbCourse = await _context.Courses.Include(m=>m.CourseImages).Include(m=>m.CourseAuthor).FirstOrDefaultAsync(m => m.id == id);

            if (dbCourse is null) return NotFound();

            CourseDetailVM model = new()
            {
                CourseImages = dbCourse.CourseImages,
                CourseAuthor= dbCourse.CourseAuthor,
                Title= dbCourse.Title,
                Description= dbCourse.Description,
                Price= dbCourse.Price,
            };

            return View(model);
    }   }
}

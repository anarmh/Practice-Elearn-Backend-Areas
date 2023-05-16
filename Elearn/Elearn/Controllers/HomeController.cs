using Elearn.Data;
using Elearn.Models;
using Elearn.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;

namespace Elearn.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<Slider> sliders = await _context.Sliders.Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<FeaturedCourseAuthor> featuredCourseAuthors = await _context.FeaturedCoursesAuthor.Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<FeaturedCourse> featuredCourses = await _context.FeaturedCourses.Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<FeaturedCourseImage> featuredCourseImages = await _context.FeaturedCoursesImage.Where(m => !m.SoftDelete).Where(m => m.IsMain).ToListAsync();
            IEnumerable<CourseAuthor> courseAuthors = await _context.CourseAuthors.Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<Course> courses = await _context.Courses.Include(m=>m.CourseImages).Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<CourseImage> courseImages = await _context.CourseImages.Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<Milestone> milestones = await _context.Milestones.Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<Event> events = await _context.Events.Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<NewsAuthor> newsAuthors = await _context.NewsAuthors.Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<News> news = await _context.News.Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<NewsImage> newsImages = await _context.NewsImages.Where(m => !m.SoftDelete).ToListAsync();


            HomeVM model = new()
            {
                Sliders = sliders,
                FeaturedCourses =featuredCourses,
                FeaturedCoursesAuthors=featuredCourseAuthors,
                FeaturedCoursesImages=featuredCourseImages,
                Courses=courses,
                CourseAuthors=courseAuthors,
                CourseImages=courseImages,
                Milestones=milestones,
                Events=events,
                News=news,
                NewsImages=newsImages,
                NewsAuthors=newsAuthors,
            };

            return View(model);
        }

     
    }
}
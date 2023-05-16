using Elearn.Models;
using Microsoft.EntityFrameworkCore;

namespace Elearn.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<FeaturedCourse> FeaturedCourses { get; set; }
        public IEnumerable<FeaturedCourseAuthor> FeaturedCoursesAuthors { get; set; }
        public IEnumerable<FeaturedCourseImage> FeaturedCoursesImages { get; set; }
        public IEnumerable<CourseAuthor> CourseAuthors { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<CourseImage> CourseImages { get; set; }
        public IEnumerable<Milestone> Milestones { get; set; }
        public IEnumerable<Event> Events { get; set; }
        public IEnumerable<NewsAuthor> NewsAuthors { get; set; }
        public IEnumerable<News> News { get; set; }
        public IEnumerable<NewsImage> NewsImages { get; set; }

    }
}

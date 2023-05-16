using Elearn.Models;

namespace Elearn.ViewModels
{
    public class CourseVM
    {
        public IEnumerable<CourseAuthor> CourseAuthors { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<CourseImage> CourseImages { get; set; }
    }
}

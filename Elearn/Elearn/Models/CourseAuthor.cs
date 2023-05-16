namespace Elearn.Models
{
    public class CourseAuthor:BaseEntity
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public ICollection<Course> Courses { get; set; }
        public ICollection<CourseAuthorImage> CourseAuthorImages { get; set; }
    }
}

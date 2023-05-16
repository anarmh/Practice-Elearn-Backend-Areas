namespace Elearn.Models
{
    public class FeaturedCourseAuthor:BaseEntity
    {
        public string FullName { get; set; }
        public ICollection<FeaturedCourse> FeaturedCourses { get; set; }
    }
}

namespace Elearn.Models
{
    public class Course:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CourseAuthorId { get; set; }
        public CourseAuthor CourseAuthor { get; set; }
        public ICollection<CourseImage> CourseImages { get; set; }
    }
}

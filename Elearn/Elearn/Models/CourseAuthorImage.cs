namespace Elearn.Models
{
    public class CourseAuthorImage:BaseEntity
    {
        public string Image { get; set; }
        public int CourseAuthorId { get; set; }
        public CourseAuthor CourseAuthor { get; set; }
    }
}

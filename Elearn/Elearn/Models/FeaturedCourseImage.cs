namespace Elearn.Models
{
    public class FeaturedCourseImage:BaseEntity
    {
        public string Image { get; set; }
        public bool IsMain { get; set; }
        public int FeaturedCourseId { get; set; }
        public FeaturedCourse FeaturedCourse { get; set; }
    }
}

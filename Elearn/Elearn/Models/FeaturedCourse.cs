namespace Elearn.Models
{
    public class FeaturedCourse:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ICollection<FeaturedCourseImage> FeaturedCourseImages { get; set; }
        public int FeaturedCourseAuthorId { get; set; }
        public FeaturedCourseAuthor featuredCourseAuthor { get; set; }
    }
}

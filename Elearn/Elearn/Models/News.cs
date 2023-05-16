namespace Elearn.Models
{
    public class News :BaseEntity
    {
        public string PostTitle { get; set; }
        public ICollection<NewsImage> NewsImages { get; set; }
        public int AuthorId { get; set; }
        public NewsAuthor NewsAuthor { get; set; }
    }
}

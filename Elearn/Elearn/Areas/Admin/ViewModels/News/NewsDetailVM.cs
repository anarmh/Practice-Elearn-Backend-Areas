using Elearn.Models;

namespace Elearn.Areas.Admin.ViewModels.News
{
    public class NewsDetailVM
    {
        public string PostTitle { get; set; }
        public ICollection<NewsImage> NewsImages { get; set; }
        public int AuthorId { get; set; }
        public NewsAuthor NewsAuthor { get; set; }
    }
}

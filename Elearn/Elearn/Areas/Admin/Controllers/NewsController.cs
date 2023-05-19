using Elearn.Areas.Admin.ViewModels.News;
using Elearn.Data;
using Elearn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Elearn.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NewsController : Controller
    {
        private readonly AppDbContext _context;

        public NewsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<NewsVM> listNews = new();
            List<News> news= await _context.News.Include(m=>m.NewsImages).Include(m=>m.NewsAuthor).Where(m=>!m.SoftDelete).ToListAsync();
            foreach (var item in news)
            {
                NewsVM model = new()
                {
                    Id = item.id,
                    PostTitle = item.PostTitle,
                    NewsAuthor = item.NewsAuthor,
                    NewsImages = item.NewsImages,
                };
                listNews.Add(model);
            }

            return View(listNews);
        }



        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();
            News dbNew = await _context.News.Include(m => m.NewsImages).Include(m => m.NewsAuthor).FirstOrDefaultAsync(m => m.id == id);
            
            if (dbNew == null) return NotFound();

            NewsDetailVM model = new()
            {
                PostTitle = dbNew.PostTitle,
                NewsAuthor = dbNew.NewsAuthor,
                NewsImages = dbNew.NewsImages,
            };
            return View(model);
        }
    }
}

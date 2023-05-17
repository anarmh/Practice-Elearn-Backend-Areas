using Elearn.Areas.Admin.ViewModels.Slider;
using Elearn.Data;
using Elearn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Elearn.Areas.Admin.Controllers
{
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;

        public SliderController(AppDbContext context)
        {
            _context = context;
        }

        [Area("Admin")]
        public async Task<IActionResult> Index()
        {
            List<SliderVM> listSlider = new();
            List<Slider> sliders = await _context.Sliders.ToListAsync();
            foreach (var slider in sliders)
            {
                SliderVM model = new()
                {
                    Id = slider.id,
                    Image = slider.Image,
                    Logo = slider.Logo,
                    Title = slider.Title,
                    Description = slider.Description,
                    Status = slider.Status,
                    CreateDate = slider.CreateDate.ToString("dd-mm-yyyy")
                };
                listSlider.Add(model);
            }

            return View(listSlider);
        }

        [Area("Admin")]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            Slider dbSlider = await _context.Sliders.FirstOrDefaultAsync(m => m.id == id);

            if (dbSlider is null) return NotFound();

            SliderDetailVM model = new()
            {
                Image = dbSlider.Image,
                Logo = dbSlider.Logo,
                Title = dbSlider.Title,
                Description = dbSlider.Description,
                CreateDate = dbSlider.CreateDate.ToString("dd-mm-yyyy"),
                Status = dbSlider.Status
            };

            return View(model);

        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Simulation3.DataAccessLayer;
using Simulation3.ViewModel.ProductViewModels;

namespace Simulation3.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CourseController(AppDbContext _context):Controller
    {
        public async Task<IActionResult> Index()
        {
            var courses = await _context.Products.Select(x => new CourseGetVm()
            {
                Id = x.Id,
                ImagePath = x.ImagePath,
                DateTime = x.DateTime,
                Description = x.Description,
                Title = x.Title,
               Trainer = x.Category.Name,
            }).ToListAsync();
            return View(courses);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
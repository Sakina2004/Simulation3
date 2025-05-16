using System.Drawing;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Simulation3.DataAccessLayer;
using Simulation3.Models;
using Simulation3.ViewModel.ProductViewModels;
using Simulation3.ViewModels.CourseViewModels;

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
                Time = x.Time,
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
        [HttpPost]
        public async Task<IActionResult> Create(CourseCreateVm vm)
        {
            if (!ModelState.IsValid)
                return View(vm);
            if (vm.Image.Length * 1024 * 1024 > 2)
            {
                ModelState.AddModelError("ImageFile", "Shekilin olchusu 2 kb-i keche bilmez!");
                return View(vm);
            }
            if (!vm.Image.ContentType.Contains("image"))
            {
                ModelState.AddModelError("Image", "Datanin shekil formatinda oldughuna diqqet edin!");
                return View(vm);
            }
            string filename = Guid.NewGuid().ToString() + vm.Image.FileName;
            string path = Path.Combine("wwwroot" ,"images", filename);
            using FileStream stream = new(path, FileMode.OpenOrCreate);
            await vm.Image.CopyToAsync(stream);
            Course course = new()
            {
               
                Time = vm.Time,
                Description = vm.Description,
                Title = vm.Title,
                CategoryId = vm.CategoryId,
            };
            await _context.Products.AddAsync(course);  
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        
        public async Task<IActionResult> Delete(int?id)
        {
            if (!id.HasValue || id < 1)
                return BadRequest();
         var  entity =await _context.Products.Where(x=>x.Id==id).ExecuteDeleteAsync();
            if (entity == 0)
                return NotFound();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult>Update(int? id)
        {
            return Ok();
        }
        [HttpPost]

        //public async Task<IActionResult>Update(int? id,CourseUpdateVm vm)
        //{
        //    if(!id.HasValue || id < 1)
        //        return BadRequest();
            
        //}
     }
}
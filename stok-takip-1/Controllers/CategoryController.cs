using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using stok_takip_1.Data.Abstract;
using stok_takip_1.Data.Concrete;
using stok_takip_1.Entities;
using stok_takip_1.Models;

namespace stok_takip_1.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoriesRepository _categoriesRepository;
        public CategoryController(ICategoriesRepository categoriesRepository)
        {
            _categoriesRepository = categoriesRepository;
        }


        // 3 sayfa, listeleme, ekleme, silme

        // listeleme
        public IActionResult Index()
        {
            return View(_categoriesRepository.Categories);
        }

        // ekleme
        [HttpGet]
        public IActionResult Create(int? id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                _categoriesRepository.CreateCategory(new Categories()
                {
                    Category_name = model.Category_Name,
                    Description = model.Category_Description
                });
                return RedirectToAction("Index");
            }
            // Markayı ekledikten sonra markaların listelendiği sayfaya(index) yönlendirme yapılıyor
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var category = await _categoriesRepository.Categories.FirstOrDefaultAsync(m => m.Category_id == id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([FromForm]int id)
        {
            try
            {
                var category = await _categoriesRepository.Categories.FirstOrDefaultAsync(m => m.Category_id == id);
                if (category == null)
                {
                    return NotFound();
                }
                _categoriesRepository.DeleteCategory(category);
            }
            catch (Exception)
            {
                throw;
            }

            return RedirectToAction("Index");
        }



        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = _categoriesRepository
                .Categories
                .Select(k => new CategoryViewModel
                {
                    Category_id= k.Category_id,
                    Category_Name = k.Category_name,
                    Category_Description = k.Description
                }).FirstOrDefault(k => k.Category_id == id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(int id, CategoryViewModel model)
        {
            if (id != model.Category_id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _categoriesRepository.EditCategory(new Categories()
                {
                    Category_id= model.Category_id,
                    Category_name= model.Category_Name,
                    Description= model.Category_Description
                });
                return RedirectToAction("Index");
            }
            return View();
        }




    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using stok_takip_1.Data.Abstract;
using stok_takip_1.Entities;
using stok_takip_1.Models;

namespace stok_takip_1.Controllers
{
    public class BrandController : Controller
    {
        private IBrandsRepository _brandsRepository;
        public BrandController(IBrandsRepository brandsRepository)
        {
            _brandsRepository = brandsRepository;
        }


        // Markaların listelenme ekranı
        public IActionResult Index()
        {
            return View(_brandsRepository.Brands);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BrandViewModel model)
        {
            if (ModelState.IsValid)
            {
                _brandsRepository.CreateBrand(new Product_Brands
                {
                    Brand_Name = model.BrandName,
                    Brand_Description = model.BrandDescription
                });
            }
            // Markayı ekledikten sonra markaların listelendiği sayfaya(index) yönlendirme yapılıyor
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var marka = await _brandsRepository.Brands.FirstOrDefaultAsync(m => m.Brand_id == id);

            if (marka == null)
            {
                return NotFound();
            }

            return View(marka);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([FromForm] int id)
        {
            try
            {
                var marka = await _brandsRepository.Brands.FirstOrDefaultAsync(m => m.Brand_id == id);
                if (marka == null)
                {
                    return NotFound();
                }
                _brandsRepository.DeleteBrand(marka);
            }
            catch (Exception)
            {
                throw;
            }

            return RedirectToAction("Index");
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            return View();
        }

    }
}

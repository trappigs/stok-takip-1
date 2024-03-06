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


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marka = _brandsRepository
                .Brands
                .Select(k => new BrandViewModel
                {
                    BrandId = k.Brand_id,
                    BrandName = k.Brand_Name,
                    BrandDescription = k.Brand_Description
                }).FirstOrDefault(k => k.BrandId == id);

            if (marka == null)
            {
                return NotFound();
            }

            return View(marka);
        }

        [HttpPost]
        public IActionResult Edit(int id, BrandViewModel model)
        {
            if (id != model.BrandId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _brandsRepository.EditBrand(new Product_Brands()
                {
                    Brand_id = model.BrandId,
                    Brand_Name = model.BrandName,
                    Brand_Description = model.BrandDescription
                });
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}

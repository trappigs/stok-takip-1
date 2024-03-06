using Microsoft.AspNetCore.Mvc;
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


        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            return View();
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

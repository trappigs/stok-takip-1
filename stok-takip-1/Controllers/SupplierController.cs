using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using stok_takip_1.Data.Abstract;
using stok_takip_1.Entities;
using stok_takip_1.Models;

namespace stok_takip_1.Controllers
{
    public class SupplierController : Controller
    {
        private ISuppliersRepository _supplierRepository;
        public SupplierController(ISuppliersRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }


        // Markaların listelenme ekranı
        public IActionResult Index()
        {
            return View(_supplierRepository.Suppliers);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(SupplierViewModel model)
        {
            if (ModelState.IsValid)
            {
                _supplierRepository.CreateSupplier(new Suppliers
                {
                    Supplier_name = model.Supplier_name,
                    Supplier_phone = model.Supplier_phone,
                    Supplier_address = model.Supplier_address,
                    Supplier_email = model.Supplier_email,
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
            var supplier = await _supplierRepository.Suppliers.FirstOrDefaultAsync(m => m.Supplier_id == id);

            if (supplier == null)
            {
                return NotFound();
            }

            return View(supplier);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([FromForm] int id)
        {
            try
            {
                var supplier = await _supplierRepository.Suppliers.FirstOrDefaultAsync(m => m.Supplier_id == id);
                if (supplier == null)
                {
                    return NotFound();
                }
                _supplierRepository.DeleteSupplier(supplier);
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

            var supplier = _supplierRepository
                .Suppliers
                .Select(k => new SupplierViewModel
                {
                    Supplier_id= k.Supplier_id,
                    Supplier_name= k.Supplier_name,
                    Supplier_phone= k.Supplier_phone,
                    Supplier_address= k.Supplier_address,
                    Supplier_email= k.Supplier_email
                }).FirstOrDefault(k => k.Supplier_id == id);

            if (supplier == null)
            {
                return NotFound();
            }

            return View(supplier);
        }

        [HttpPost]
        public IActionResult Edit(int id, SupplierViewModel model)
        {
            if (id != model.Supplier_id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _supplierRepository.UpdateSupplier(new Suppliers()
                {
                    Supplier_id= model.Supplier_id,
                    Supplier_name = model.Supplier_name,
                    Supplier_address = model.Supplier_address,
                    Supplier_phone = model.Supplier_phone,
                    Supplier_email = model.Supplier_email
                });
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}

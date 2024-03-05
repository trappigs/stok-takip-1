using Microsoft.AspNetCore.Mvc;

namespace stok_takip_1.Controllers
{
    public class BrandController : Controller
    {



        // Markaların listelenme ekranı
        public IActionResult Index()
        {
            return View();
        }
    }
}

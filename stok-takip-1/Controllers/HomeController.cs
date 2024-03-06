using Microsoft.AspNetCore.Mvc;
using stok_takip_1.Models;
using System.Diagnostics;

namespace stok_takip_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

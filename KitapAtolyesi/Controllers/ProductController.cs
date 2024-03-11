using Microsoft.AspNetCore.Mvc;

namespace KitapAtolyesi.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {
            return View();
        }
    }
}

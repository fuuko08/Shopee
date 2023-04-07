using Microsoft.AspNetCore.Mvc;

namespace Shopee.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}


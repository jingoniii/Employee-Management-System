using Microsoft.AspNetCore.Mvc;

namespace AuthNew.Controllers
{
    public class FAQController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

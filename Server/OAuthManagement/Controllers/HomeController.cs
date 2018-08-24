using Microsoft.AspNetCore.Mvc;

namespace OAuthManagement.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

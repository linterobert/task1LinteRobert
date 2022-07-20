using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.TestCommit
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

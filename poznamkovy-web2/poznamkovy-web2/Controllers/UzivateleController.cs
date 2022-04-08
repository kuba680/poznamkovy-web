using Microsoft.AspNetCore.Mvc;

namespace poznamkovy_web2.Controllers
{
    public class UzivateleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

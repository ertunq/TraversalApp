using Microsoft.AspNetCore.Mvc;

namespace TraversalApp.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

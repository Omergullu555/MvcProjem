using Microsoft.AspNetCore.Mvc;

namespace MvcProjem.Controllers
{
    public class PlanlamaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

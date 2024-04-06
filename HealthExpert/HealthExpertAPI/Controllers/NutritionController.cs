using Microsoft.AspNetCore.Mvc;

namespace HealthExpertAPI.Controllers
{
    public class NutritionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

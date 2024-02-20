using Microsoft.AspNetCore.Mvc;

namespace HealthExpertAPI.Controllers
{
    public class BMIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

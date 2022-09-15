using Microsoft.AspNetCore.Mvc;

namespace CRM_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger logger;
        public HomeController(ILogger<HomeController> logger)
        {
            this.logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
    
}

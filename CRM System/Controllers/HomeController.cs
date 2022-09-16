using Microsoft.AspNetCore.Mvc;

namespace CRM_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger _logger; 
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            _logger.LogCritical("----->Все хорошо");
            return View();
        }
    }
    
}

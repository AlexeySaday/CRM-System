using CRM_System.IDataModel;
using Microsoft.AspNetCore.Mvc;

namespace CRM_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger _logger;
        private readonly IAppData data;
        public HomeController(ILogger<HomeController> logger, IAppData appdata)
        {
            this.data = appdata;
            _logger = logger;
        }
        public IActionResult Index()
        {
            _logger.LogCritical("----->Все хорошо");
            return View();
        }
         
    }
    
}

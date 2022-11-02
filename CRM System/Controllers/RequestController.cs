using CRM_System.IDataModel;
using CRM_System.Models; 
using Microsoft.AspNetCore.Mvc; 

namespace CRM_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        private readonly IAppData data;
        public RequestController(IAppData data)
        {
            this.data = data;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Message>> Get()
        {
            return data.GetMessages().ToList();
        }
        [HttpGet("{date}")]
        public ActionResult<IEnumerable<Message>> Get(string date)
        {
            return data.GetMessages().Where(e => e.AppDate == date).ToList();
        }
    }
}

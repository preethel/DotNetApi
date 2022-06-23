using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public string MyName()
        {
            return "Redwan";
        }
        [HttpGet]
        public string MyFullName(){
            return "Md. Nur A Redwan Ul Azam";
        }
    }
}

using ColonyManager.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ColonyManager.WebApi.Host.Controllers
{
    public class BaseController : ControllerBase
    {
        public Account Account => (Account)HttpContext.Items["Account"];
    }
}

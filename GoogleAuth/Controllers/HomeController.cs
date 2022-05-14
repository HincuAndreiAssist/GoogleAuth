using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleAuth.Controllers
{
    [Authorize]
    public class HomeController : ControllerBase
    {
        public HomeController()
        {

        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}

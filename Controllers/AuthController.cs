using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreGoogleAuth.Controllers
{
     [Route("api/login")]
     public class AuthController : Controller
     {
		[HttpGet, Authorize]
		public IActionResult Login()
		{
            	return Redirect("/");
		}
	}
}
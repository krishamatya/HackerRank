using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SignalRAuth.Areas.Identity.Data;
using SignalRAuth.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRAuth.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SignInManager<SignalRAuthUser> _signInManager;
        private readonly UserManager<SignalRAuthUser> _userManager;
        public HomeController(SignInManager<SignalRAuthUser> signInManager,ILogger<HomeController> logger,UserManager<SignalRAuthUser> userManager)
        {
            _logger = logger;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            if (_signInManager.Context.User.Identity.IsAuthenticated)
            {

               return View();
            }
            else {
                return LocalRedirect("/Identity/Account/Login");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public JsonResult IsStillLoggedIn() {
            if (_signInManager.Context.User.Identity.IsAuthenticated)
            {
               
                return Json(false);
            }
            else {
                
            
                return Json(true);
            }

        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

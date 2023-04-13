using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using SignalRAuth.Areas.Identity.Data;

namespace SignalRAuth.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LogoutModel : PageModel
    {
        private readonly SignInManager<SignalRAuthUser> _signInManager;
        private readonly ILogger<LogoutModel> _logger;
        private readonly UserManager<SignalRAuthUser> _userManager;
        public LogoutModel(SignInManager<SignalRAuthUser> signInManager, ILogger<LogoutModel> logger,UserManager<SignalRAuthUser> userManager)
        {
            _signInManager = signInManager;
            _logger = logger;
            _userManager = userManager;
           
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(string returnUrl = null)
        {

            string name = _userManager.GetUserAsync(User).Result.FirstName;
            await _signInManager.SignOutAsync();
            
            _logger.LogInformation("LoggedOutUser:"+ _userManager.GetUserAsync(User).Result.Email);
            _logger.LogInformation("LoggedOutTime" + DateTime.Now);
            if (returnUrl != null)
            {
                return LocalRedirect(returnUrl);
            }
            else
            {
                return RedirectToPage();
            }
        }
    }
}

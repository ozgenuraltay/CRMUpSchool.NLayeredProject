using CRMUpSchool.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMUpSchool.UILayer.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(AppUser appUser)
        {
            var users =await _signInManager.PasswordSignInAsync(appUser.UserName, appUser.PasswordHash, false, true); //3. değer olan 'false', çerezlerin kaydolması, 4. değer olan 'true' hatalı girişte kilitlenme olsun'u gösterir.
            if (users.Succeeded&& appUser.EmailConfirmed==true)
            {
                return RedirectToAction("Index", "User");
            }
            return View();
        }
    }
}

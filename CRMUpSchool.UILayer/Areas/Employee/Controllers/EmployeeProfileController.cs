using CRMUpSchool.EntityLayer.Concrete;
using CRMUpSchool.UILayer.Areas.Employee.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CRMUpSchool.UILayer.Areas.Employee.Controllers
{
    [Area("Employee")]
    public class EmployeeProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public EmployeeProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            UserEditProfileVM userEditProfileVM = new UserEditProfileVM();

            userEditProfileVM.Name = user.Name;
            userEditProfileVM.Surname = user.Surname;
            userEditProfileVM.PhoneNumber = user.PhoneNumber;
            userEditProfileVM.Email = user.Email;

            return View(userEditProfileVM);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditProfileVM userEditProfileVM)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (userEditProfileVM.Image!=null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(userEditProfileVM.Image.FileName);
                var imageName = Guid.NewGuid()+extension;
                var saveLocation = resource + "/wwwroot/UserImages/" + imageName;

                var stream = new FileStream(saveLocation, FileMode.Create);
                await userEditProfileVM.Image.CopyToAsync(stream);
                user.ImageURL = imageName;
            }
            user.Name = userEditProfileVM.Name;
            user.Surname = userEditProfileVM.Surname;
            user.PhoneNumber = userEditProfileVM.PhoneNumber;
            user.Email = userEditProfileVM.Email;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEditProfileVM.Password);
            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction("Index","Login");
            }
            return View();
        }
    }
}

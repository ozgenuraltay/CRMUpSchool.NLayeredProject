using CRMUpSchool.EntityLayer.Concrete;
using CRMUpSchool.UILayer.Models;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMUpSchool.UILayer.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserSignUpModel model)
        {
            Random random = new Random();
            int number = random.Next(100000, 999999);
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    UserName = model.UserName,
                    Name = model.Name,
                    Surname = model.Surname,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber,
                    MailCode=number.ToString()
                };
                if (model.Password == model.ConfirmPassword)
                {
                    var result = await _userManager.CreateAsync(appUser, model.Password);
                    if (result.Succeeded)
                    {
                        SendEmail(appUser.MailCode);
                        return RedirectToAction("EmailConfirmed", "Register");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Girdiğiniz şifreler uyuşmuyor.");
                }
            }
            return View();
        }

        public void SendEmail(string emailcode)
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "testozge8@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom); //Mailin kimden gönderildiği

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", "testozge8@gmail.com");
            mimeMessage.To.Add(mailboxAddressTo); //Mailin kime gönderileceği

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = emailcode;
            mimeMessage.Body = bodyBuilder.ToMessageBody(); //Gönderilecek mailin body'si

            mimeMessage.Subject = "Üyelik Kaydı Email Doğrulama"; //Gönderilecek mailin başlığı

            SmtpClient smtp = new SmtpClient(); //SİMPLE MAİL TRANSFER PROTOCOL
            smtp.Connect("smtp.gmail.com", 587, false);
            //////////////
            smtp.Send(mimeMessage);
            smtp.Disconnect(true);
        }

        [HttpGet]
        public IActionResult EmailConfirmed()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> EmailConfirmed(AppUser appUser)
        {
            var user = await _userManager.FindByEmailAsync(appUser.Email);
            if (user.MailCode == appUser.MailCode)
            {
                user.EmailConfirmed = true;

                await _userManager.UpdateAsync(user);
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}

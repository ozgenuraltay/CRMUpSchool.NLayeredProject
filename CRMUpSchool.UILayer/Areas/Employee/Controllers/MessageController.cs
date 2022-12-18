using CRMUpSchool.BusinessLayer.Abstract;
using CRMUpSchool.DataAccessLayer.Concretee;
using CRMUpSchool.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMUpSchool.UILayer.Areas.Employee.Controllers
{
    [Area("Employee")]
    public class MessageController : Controller
    {
        private readonly IMessageService _messageService;
        private readonly UserManager<AppUser> _userManager;

        public MessageController(IMessageService messageService, UserManager<AppUser> userManager)
        {
            _messageService = messageService;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessageAsync(Message message)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            message.Date =Convert.ToDateTime(DateTime.Now.ToShortDateString());
            message.SenderEmail = user.Email;
            message.SenderName = user.Name +" "+ user.Surname;

            using (var context=new Context()) //Gönderilenin mailine göre adı-soyadını buldum.
            {
                message.ReceiverName= context.Users.Where(x => x.Email == message.ReceiverEmail).Select(x => x.Name + " " + x.Surname).FirstOrDefault();
            }
            _messageService.TInsert(message);
            return RedirectToAction("SendMessage");
        }
    }
}

//srjfhuqetjaljxxq -->mail
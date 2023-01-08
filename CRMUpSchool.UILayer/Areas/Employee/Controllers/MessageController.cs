using CRMUpSchool.BusinessLayer.Abstract;
using CRMUpSchool.DataAccessLayer.Concretee;
using CRMUpSchool.EntityLayer.Concrete;
using CRMUpSchool.UILayer.Areas.Employee.Models;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
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
            message.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            message.SenderEmail = user.Email;
            message.SenderName = user.Name + " " + user.Surname;

            using (var context = new Context()) //Gönderilenin mailine göre adı-soyadını buldum.
            {
                message.ReceiverName = context.Users.Where(x => x.Email == message.ReceiverEmail).Select(x => x.Name + " " + x.Surname).FirstOrDefault();
            }
            _messageService.TInsert(message);

            var mailRequest = new MailRequest();
            mailRequest.MailContent = message.MessageContent;
            mailRequest.MailSubject = message.MessageSubject;
            mailRequest.ReceiverMail = message.ReceiverEmail;

            SendEmail(mailRequest);

            return RedirectToAction("SendMessage");
        }

        [HttpGet]
        public IActionResult SendEmail()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> SendEmail(MailRequest mailRequest)
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "testozge8@gmail.com"); //ikinci parametre gönderenin maili
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", mailRequest.ReceiverMail); //ikinci parametre mail gidenin maili
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = mailRequest.MailContent;
            mimeMessage.Body = bodyBuilder.ToMessageBody();
            mimeMessage.Subject = mailRequest.MailSubject;

            SmtpClient client = new SmtpClient();

            client.Connect("smtp.gmail.com", 587, false); //ikinci parametre türkiye için port numarası, üçüncü parametre ssl kullanıp kullanmaması
            //////////////////
            client.Send(mimeMessage);
            client.Disconnect(true);
            return View();
        }
    }
}

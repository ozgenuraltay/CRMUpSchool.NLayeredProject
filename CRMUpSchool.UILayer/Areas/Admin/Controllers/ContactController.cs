using CRMUpSchool.BusinessLayer.Abstract;
using CRMUpSchool.DTOLayer.ContactDTOs;
using CRMUpSchool.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMUpSchool.UILayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public IActionResult AddContact()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddContact(ContactAddDTO model)
        {
            if (ModelState.IsValid)
            {
                _contactService.TInsert(new Contact()
                {
                    Name = model.Name,
                    Mail = model.Mail,
                    Content = model.Content,
                    Subject = model.Subject,
                    Date = DateTime.Parse(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}

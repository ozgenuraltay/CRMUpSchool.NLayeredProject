using CRMUpSchool.BusinessLayer.Abstract;
using CRMUpSchool.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMUpSchool.UILayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminCustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public AdminCustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CustomerList()
        {
            var jsonCustomers = JsonConvert.SerializeObject(_customerService.TGetList());
            return Json(jsonCustomers);
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            _customerService.TInsert(customer);
            var values = JsonConvert.SerializeObject(customer);
            return View(values);
        }

        public IActionResult GetByID(int CustomerID)
        {
            var customerValues = _customerService.TGetByID(CustomerID);
            var jsonValues = JsonConvert.SerializeObject(customerValues);
            return Json(jsonValues);
        }

    }
}

using CRMUpSchool.BusinessLayer.Abstract;
using CRMUpSchool.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMUpSchool.UILayer.Controllers
{
    public class EmployeeTaskController : Controller
    {
        private readonly IEmployeeTaskService _employeeTaskService;
        private readonly UserManager<AppUser> _userManager;

        public EmployeeTaskController(IEmployeeTaskService employeeTaskService, UserManager<AppUser> userManager)
        {
            _employeeTaskService = employeeTaskService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var employeeTasks = _employeeTaskService.TGetEmployeeTaskByEmployee();
            return View(employeeTasks);
        }

        [HttpGet]
        public IActionResult AddTask()
        {

            List<SelectListItem> userValues = (from x in _userManager.Users.ToList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name +" " +x.Surname,
                                                       Value = x.Id.ToString()
                                                   }).ToList();
            ViewBag.users = userValues;
            return View();
        }

        [HttpPost]
        public IActionResult AddTask(EmployeeTask employeeTask)
        {
            employeeTask.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            employeeTask.Status = "Görev atandı.";
            _employeeTaskService.TInsert(employeeTask);
            return RedirectToAction("Index");
        }
    }
}

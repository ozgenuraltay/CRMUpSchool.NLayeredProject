using CRMUpSchool.BusinessLayer.Abstract;
using CRMUpSchool.BusinessLayer.ValidationRules;
using CRMUpSchool.EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMUpSchool.UILayer.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly ICategoryService _categoryService;

        public EmployeeController(IEmployeeService employeeService, ICategoryService categoryService)
        {
            _employeeService = employeeService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var employee = _employeeService.TGetEmployeeByCategory();
            return View(employee);
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            List<SelectListItem> categoryValues = (from x in _categoryService.TGetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.categories = categoryValues;
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            EmployeeValidator validationRules = new EmployeeValidator();
            ValidationResult result = validationRules.Validate(employee); //validasyonları kontrol ediyor.
            if (result.IsValid) //eğer validasyonlar geçerse kaydet.
            {
                _employeeService.TInsert(employee);
                return RedirectToAction("Index");
            }
            else //eğer validasyonlar geçmezse error mesajı ver.
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult DeleteEmployee(int id)
        {
            var employee = _employeeService.TGetByID(id);
            _employeeService.TDelete(employee);
            return RedirectToAction("Index");
        }

        public IActionResult ChangeStatusToFalse(int id)
        {
            _employeeService.TChangeEmployeeStatusToFalse(id);
            return RedirectToAction("Index");
        }

        public IActionResult ChangeStatusToTrue(int id)
        {
            _employeeService.TChangeEmployeeStatusToTrue(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateEmployee(int id)
        {
            var employee = _employeeService.TGetByID(id);
            return View(employee);
        }

        [HttpPost]
        public IActionResult UpdateEmployee(Employee employee)
        {
            var employees = _employeeService.TGetByID(employee.EmployeeID);
            employee.EmployeeStatus = employees.EmployeeStatus;
            _employeeService.TUpdate(employee);
            return RedirectToAction("Index");
        }


    }
}

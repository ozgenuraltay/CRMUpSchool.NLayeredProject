using CRMUpSchool.UILayer.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMUpSchool.UILayer.Areas.Employee.Controllers
{
    [Area("Employee")]
    public class ChartController : Controller
    {
        List<DepartmantSalary> departmantSalaries = new List<DepartmantSalary>();

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult DepartmantChart()
        {
            departmantSalaries.Add(new DepartmantSalary
            {
                departmantname = "Muhasebe",
                salaryavg = 10000
            });
            departmantSalaries.Add(new DepartmantSalary
            {
                departmantname = "IT",
                salaryavg = 30000
            });
            departmantSalaries.Add(new DepartmantSalary
            {
                departmantname = "Satış",
                salaryavg = 20000
            });

            return Json(new {jsonList=departmantSalaries});
        }


    }
}

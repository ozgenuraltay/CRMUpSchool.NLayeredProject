using CRMUpSchool.DataAccessLayer.Concretee;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMUpSchool.UILayer.ViewComponents.Dashboard
{
    public class _OverviewDashboardPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using (var context = new Context())
            {
                ViewBag.EmployeeCount = context.Employees.Count();

                ViewBag.EmployeeWomanGenderCount = context.Users.Where(x => x.Gender == "Kadın").Count();

                var id = context.Users.Max(x => x.Id);
                ViewBag.LastUser = context.Users.Where(x => x.Id == id).Select(x => x.Name + " " + x.Surname).FirstOrDefault();
            }
            return View();
        }
    }
}

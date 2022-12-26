using CRMUpSchool.UILayer.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMUpSchool.UILayer.ViewComponents.Dashboard
{
    public class _ChartDashboardPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}

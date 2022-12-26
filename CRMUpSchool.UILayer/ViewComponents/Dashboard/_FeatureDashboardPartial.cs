using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMUpSchool.UILayer.ViewComponents.Dashboard
{
    public class _FeatureDashboardPartial:ViewComponent    
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

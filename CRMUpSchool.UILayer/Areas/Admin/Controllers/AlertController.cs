using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMUpSchool.UILayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AlertController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

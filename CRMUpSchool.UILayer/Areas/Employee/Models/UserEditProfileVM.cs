﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMUpSchool.UILayer.Areas.Employee.Models
{
    public class UserEditProfileVM
    {

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string ImageURL { get; set; }

        public IFormFile Image { get; set; }  //dosya formatı olacak (IFormFile)
    }
}

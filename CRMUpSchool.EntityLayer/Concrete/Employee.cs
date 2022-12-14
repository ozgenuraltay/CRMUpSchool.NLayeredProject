﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMUpSchool.EntityLayer.Concrete
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        public string EmployeeName { get; set; }

        public string EmployeeSurname { get; set; }

        public string EmployeeMail { get; set; }

        public string EmployeeImage { get; set; }

        public int CategoryID { get; set; }

        public  Category Category{ get; set; }

        public bool EmployeeStatus { get; set; }

     
    }
}

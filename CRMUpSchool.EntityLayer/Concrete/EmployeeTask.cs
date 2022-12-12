﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMUpSchool.EntityLayer.Concrete
{
    public class EmployeeTask
    {
        public int EmployeeTaskID { get; set; }

        public string Title { get; set; }

        public string Details { get; set; }

        public string Status { get; set; }

        public DateTime Date { get; set; }

        public int EmployeeID { get; set; }

        public Employee Employee { get; set; }
    }
}

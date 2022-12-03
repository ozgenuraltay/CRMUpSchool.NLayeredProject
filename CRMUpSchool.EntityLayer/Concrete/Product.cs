﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMUpSchool.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public decimal ProductPrice{ get; set; }

        public int ProductStock { get; set; }
    }
}

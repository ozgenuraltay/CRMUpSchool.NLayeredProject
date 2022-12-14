﻿using CRMUpSchool.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMUpSchool.BusinessLayer.Abstract
{
    public interface IEmployeeTaskService:IGenericService<EmployeeTask>
    {
        List<EmployeeTask> TGetEmployeeTaskByEmployee();

        List<EmployeeTask> TGetEmployeeTaskByID(int id);
    }
}

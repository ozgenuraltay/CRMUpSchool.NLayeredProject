﻿using CRMUpSchool.DataAccessLayer.Abstract;
using CRMUpSchool.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMUpSchool.BusinessLayer.Abstract
{
    public interface IEmployeeTaskDetailService:IGenericService<EmployeeTaskDetail>
    {
        List<EmployeeTaskDetail> TGetEmployeeTaskDetailByID(int id);
    }
}

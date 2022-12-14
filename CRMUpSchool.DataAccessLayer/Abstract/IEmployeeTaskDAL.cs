using CRMUpSchool.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMUpSchool.DataAccessLayer.Abstract
{
   public  interface IEmployeeTaskDAL :IGenericDAL<EmployeeTask>
    {
        List<EmployeeTask> GetEmployeeTaskByEmployee();

        List<EmployeeTask> GetEmployeeTaskByID(int id);
    }
}

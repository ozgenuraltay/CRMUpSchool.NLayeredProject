using CRMUpSchool.DataAccessLayer.Abstract;
using CRMUpSchool.DataAccessLayer.Concretee;
using CRMUpSchool.DataAccessLayer.Repository;
using CRMUpSchool.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMUpSchool.DataAccessLayer.EntityFramework
{
   public  class EFEmployeeTaskDAL:GenericRepository<EmployeeTask>,IEmployeeTaskDAL
    {
        public List<EmployeeTask> GetEmployeeTaskByEmployee()
        {
            using (var context = new Context()) {
                var employeeTask=context.EmployeeTasks.Include(x => x.Employee).ToList();
                return employeeTask;
            }
        }
    }
}

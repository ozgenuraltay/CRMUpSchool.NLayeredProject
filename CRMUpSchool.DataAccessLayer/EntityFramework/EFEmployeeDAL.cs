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
    public class EFEmployeeDAL : GenericRepository<Employee>, IEmployeeDAL
    {
        public void ChangeEmployeeStatusToFalse(int id)
        {
            using (var context = new Context())
            {
                var employee = context.Employees.Find(id);
                employee.EmployeeStatus = false;
                context.SaveChanges();
            }
         }

        public void ChangeEmployeeStatusToTrue(int id)
        {
            using (var context = new Context())
            {
                var employee = context.Employees.Find(id);
                employee.EmployeeStatus = true;
                context.SaveChanges();
            }
        }

        public List<Employee> GetEmployeeByCategory()
        {
            using (var context = new Context())
            {
                return context.Employees.Include(x => x.Category).ToList();
            }
        }
    }
}

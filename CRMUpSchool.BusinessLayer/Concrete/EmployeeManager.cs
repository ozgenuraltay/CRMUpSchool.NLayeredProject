using CRMUpSchool.BusinessLayer.Abstract;
using CRMUpSchool.DataAccessLayer.Abstract;
using CRMUpSchool.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMUpSchool.BusinessLayer.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDAL _employeeDAL;

        public EmployeeManager(IEmployeeDAL employeeDAL)
        {
            _employeeDAL = employeeDAL ;
        }

        public void TChangeEmployeeStatusToFalse(int id)
        {
            _employeeDAL.ChangeEmployeeStatusToFalse(id);
        }

        public void TChangeEmployeeStatusToTrue(int id)
        {
            _employeeDAL.ChangeEmployeeStatusToTrue(id);
        }

        public void TDelete(Employee t)
        {
            _employeeDAL.Delete(t);
        }

        public Employee TGetByID(int id)
        {
            return _employeeDAL.GetByID(id);
        }

        public List<Employee> TGetEmployeeByCategory()
        {
            return _employeeDAL.GetEmployeeByCategory();
        }

        public List<Employee> TGetList()
        {
            return _employeeDAL.GetList();
        }

        public void TInsert(Employee t)
        {
            _employeeDAL.Insert(t);
        }

        public void TUpdate(Employee t)
        {
            _employeeDAL.Update(t);
        }
    }
}

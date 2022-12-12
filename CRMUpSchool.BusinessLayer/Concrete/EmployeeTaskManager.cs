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
    public class EmployeeTaskManager : IEmployeeTaskService
    {
        IEmployeeTaskDAL _employeeTaskDAL;

        public EmployeeTaskManager(IEmployeeTaskDAL employeeTaskDAL)
        {
            _employeeTaskDAL = employeeTaskDAL;
        }

        public List<EmployeeTask> GetEmployeeTaskByEmployee()
        {
            return _employeeTaskDAL.GetEmployeeTaskByEmployee();
        }

        public void TDelete(EmployeeTask t)
        {
            throw new NotImplementedException();
        }

        public EmployeeTask TGetByID(int ID)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeTask> TGetList()
        {
            return _employeeTaskDAL.GetList();
        }

        public void TInsert(EmployeeTask t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(EmployeeTask t)
        {
            throw new NotImplementedException();
        }
    }
}

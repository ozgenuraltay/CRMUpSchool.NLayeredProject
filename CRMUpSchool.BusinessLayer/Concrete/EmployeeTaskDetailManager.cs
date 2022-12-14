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
    public class EmployeeTaskDetailManager : IEmployeeTaskDetailService
    {
        IEmployeeTaskDetailDAL _employeeTaskDetailDAL;

        public EmployeeTaskDetailManager(IEmployeeTaskDetailDAL employeeTaskDetailDAL)
        {
            _employeeTaskDetailDAL = employeeTaskDetailDAL;
        }

        public void TDelete(EmployeeTaskDetail t)
        {
            throw new NotImplementedException();
        }

        public EmployeeTaskDetail TGetByID(int ID)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeTaskDetail> TGetEmployeeTaskDetailByID(int id)
        {
            return _employeeTaskDetailDAL.GetEmployeeTaskDetailByID(id);
        }

        public List<EmployeeTaskDetail> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(EmployeeTaskDetail t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(EmployeeTaskDetail t)
        {
            throw new NotImplementedException();
        }
    }
}

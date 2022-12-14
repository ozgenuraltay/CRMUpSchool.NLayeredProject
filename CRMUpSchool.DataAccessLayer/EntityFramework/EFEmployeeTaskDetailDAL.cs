using CRMUpSchool.DataAccessLayer.Abstract;
using CRMUpSchool.DataAccessLayer.Concretee;
using CRMUpSchool.DataAccessLayer.Repository;
using CRMUpSchool.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMUpSchool.DataAccessLayer.EntityFramework
{
    public class EFEmployeeTaskDetailDAL : GenericRepository<EmployeeTaskDetail>, IEmployeeTaskDetailDAL
    {
        public List<EmployeeTaskDetail> GetEmployeeTaskDetailByID(int id)
        {
            using (var context = new Context())
            {
                return context.EmployeeTaskDetails.Where(x => x.EmployeeTaskID == id).ToList();
            }
        }
    }
}

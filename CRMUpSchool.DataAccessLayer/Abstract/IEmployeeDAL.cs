using CRMUpSchool.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMUpSchool.DataAccessLayer.Abstract
{
    public interface IEmployeeDAL : IGenericDAL<Employee>
    {
        List<Employee> GetEmployeeByCategory();

        #region Statu değişimleri
        void ChangeEmployeeStatusToTrue(int id);

        void ChangeEmployeeStatusToFalse(int id);
        #endregion

    }
}

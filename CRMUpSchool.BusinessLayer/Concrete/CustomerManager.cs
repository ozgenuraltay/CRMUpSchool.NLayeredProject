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
    public class CustomerManager : ICustomerService
    {

        ICustomerDAL _customerDAL;
        public CustomerManager(ICustomerDAL customerDAL)
        {
            _customerDAL = customerDAL;
        }

        public void TDelete(Customer t)
        {
            _customerDAL.Delete(t);
        }

        public Customer TGetByID(int ID)
        {
            return _customerDAL.GetByID(ID);
        }

        public List<Customer> TGetList()
        {
            return _customerDAL.GetList();
        }

        public void TInsert(Customer t)
        {
            _customerDAL.Insert(t);
        }

        public void TUpdate(Customer t)
        {
            _customerDAL.Update(t);
        }
    }
}

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
    public class SupplierManager : ISupplierService
    {
        ISupplierDAL _supplierDAL;

        public SupplierManager(ISupplierDAL supplierDAL)
        {
            _supplierDAL = supplierDAL;
        }

        public void TDelete(Supplier t)
        {
            throw new NotImplementedException();
        }

        public Supplier TGetByID(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Supplier> TGetList()
        {
            return _supplierDAL.GetList();
        }

        public void TInsert(Supplier t)
        {
            _supplierDAL.Insert(t);
        }

        public void TUpdate(Supplier t)
        {
            throw new NotImplementedException();
        }
    }
}

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
    public class ProductManager : IProductService
    {

        IProductDAL _productDAL;

        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public void TDelete(Product t)
        {
            _productDAL.Delete(t);
        }

        public Product TGetByID(int ID)
        {
            return _productDAL.GetByID(ID);
        }

        public List<Product> TGetList()
        {
            return _productDAL.GetList();
        }

        public void TInsert(Product t)
        {
            _productDAL.Insert(t);
        }

        public void TUpdate(Product t)
        {
            _productDAL.Update(t);
        }
    }
}

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
    public class CategoryManager : ICategoryService
    {
        ICategoryDAL _categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public void TDelete(Category t)
        {
            _categoryDAL.Delete(t);
        }

        public Category TGetByID(int ID)
        {
            return _categoryDAL.GetByID(ID);
        }

        public List<Category> TGetList()
        {
            return _categoryDAL.GetList();
        }

        public void TInsert(Category t)
        {
            //if (t.CategoryName!=null && t.CategoryName.Length>=5 && t.CategoryDescription.StartsWith("A"))
            //{
            //    _categoryDAL.Insert(t);
            //}
            //else
            //{
            //    //Hata mesajı
            //}

            _categoryDAL.Insert(t);
        }

        public void TUpdate(Category t)
        {
            _categoryDAL.Update(t);
        }
    }
}

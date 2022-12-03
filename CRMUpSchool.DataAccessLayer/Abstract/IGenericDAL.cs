using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMUpSchool.DataAccessLayer.Abstract
{
    public interface IGenericDAL<T> // where T: class  -->T'nin türünün ne olması beklendiği yazılabilir.
    {

        void Insert(T t);

        void Delete(T t);

        void Update(T t);

        List<T> GetList();

        T GetByID(int ID);

    }
}

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
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementDAL _announcementDAL;

        public AnnouncementManager(IAnnouncementDAL announcementDAL)
        {
            _announcementDAL = announcementDAL;
        }

        public List<Announcement> TContainA()
        {
            return _announcementDAL.ContainA();
        }

        public void TDelete(Announcement t)
        {
            _announcementDAL.Delete(t);
        }

        public Announcement TGetByID(int ID)
        {
            return _announcementDAL.GetByID(ID);
        }

        public List<Announcement> TGetList()
        {
            return _announcementDAL.GetList();
        }

        public void TInsert(Announcement t)
        {
            _announcementDAL.Insert(t);
        }

        public void TUpdate(Announcement t)
        {
            _announcementDAL.Update(t);
        }
    }
}

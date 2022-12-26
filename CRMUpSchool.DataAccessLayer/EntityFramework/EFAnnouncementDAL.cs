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
    public class EFAnnouncementDAL : GenericRepository<Announcement>, IAnnouncementDAL
    {
        public List<Announcement> ContainA()
        {
            using (var context=new Context())
            {
                var values = context.Announcements.Where(x => x.Title.Contains("a")).ToList();
                return values;
            }
        }
    }
}

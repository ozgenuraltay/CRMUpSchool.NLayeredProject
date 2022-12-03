using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMUpSchool.EntityLayer.Concrete
{
    public class AppUser:IdentityUser<int> /*primary key'i(ID'si) int şeklinde olsun,string olmasın diye, <int> eklendi.*/
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string ImageURL { get; set; }

        public string Gender { get; set; }
    }
}

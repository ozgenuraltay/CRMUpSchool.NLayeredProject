using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMUpSchool.EntityLayer.Concrete
{
    public class AppRole:IdentityRole<int> /*primary key'i(ID'si) int şeklinde olsun,string olmasın diye, <int> eklendi.*/
    {
    }
}

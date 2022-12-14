using CRMUpSchool.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMUpSchool.DataAccessLayer.Concretee
{
    public class Context: IdentityDbContext<AppUser,AppRole,int> //identity işlemleri için identity paketini yükleyince 'DbContext'nın yerine 'IdentityDbContext' eklenir. Kökeninde IdentityDbContext'de DbContext'ten miras alır.
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-8GBIAO0U\\SQLEXPRESS;Database=DbCRM;integrated security=true");  //integrated Security=true  --> db'ye şifresiz erişim
        }
        public DbSet<Customer> Customers  { get; set; }  //c#taki class ismiyle sql'deki tablo ismi çakışmasın diye '-s' takısı geldi. 

        public DbSet<Category> Categories  { get; set; }

        public DbSet<Product> Products  { get; set; }

        public DbSet<Employee> Employees  { get; set; }

        public DbSet<EmployeeTask> EmployeeTasks { get; set; }

        public DbSet<EmployeeTaskDetail> EmployeeTaskDetails { get; set; }
    }
}

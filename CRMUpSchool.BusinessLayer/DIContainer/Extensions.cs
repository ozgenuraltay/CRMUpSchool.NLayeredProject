using CRMUpSchool.BusinessLayer.Abstract;
using CRMUpSchool.BusinessLayer.Concrete;
using CRMUpSchool.BusinessLayer.ValidationRules.ContactValidation;
using CRMUpSchool.DataAccessLayer.Abstract;
using CRMUpSchool.DataAccessLayer.EntityFramework;
using CRMUpSchool.DTOLayer.ContactDTOs;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMUpSchool.BusinessLayer.DIContainer
{
    public static class Extensions //(Eklentiler)
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDAL, EFCategoryDAL>();

            services.AddScoped<IEmployeeService, EmployeeManager>();
            services.AddScoped<IEmployeeDAL, EFEmployeeDAL>();

            services.AddScoped<IEmployeeTaskService, EmployeeTaskManager>();
            services.AddScoped<IEmployeeTaskDAL, EFEmployeeTaskDAL>();

            services.AddScoped<IEmployeeTaskDetailService, EmployeeTaskDetailManager>();
            services.AddScoped<IEmployeeTaskDetailDAL, EFEmployeeTaskDetailDAL>();

            services.AddScoped<IMessageService, MessageManager>();
            services.AddScoped<IMessageDAL, EFMessageDAL>();

            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IAnnouncementDAL, EFAnnouncementDAL>();

            services.AddScoped<ICustomerService, CustomerManager>();
            services.AddScoped<ICustomerDAL, EFCustomerDAL>();

            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IContactDAL, EFContactDAL>();
        }

        public static void CustomizeValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<ContactAddDTO>, ContactAddValidator>();
            services.AddTransient<IValidator<ContactUpdateDTO>, ContactUpdateValidator>();
        }
    }
}

using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMUpSchool.UILayer.Models
{
    public class CustomIdentityValidator:IdentityErrorDescriber  //çıkan validation hatalarının sayfada görünen metinlerinin kontrolü
                                                                 //Startup.cs'de AddErrorDescriber<CustomIdentityValidator>() eklenmesi gerekir.
    {
        //override; mevcutta bir yapı var yine o yapıyı kullanmak istiyorum ama benim istediğim (belirttiğim) şekilde kullanmak istiyorum.

        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = $"Şifre en az {length} karakter olmalıdır."
            };
        }

        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresLower",
                Description="En az 1 tane küçük harf giriniz."
            };
        }

        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresUpper",
                Description = "En az 1 tane büyük harf giriniz."
            };
        }

        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresDigit",
                Description = "En az 1 tane sayı giriniz."
            };
        }

        public override IdentityError DuplicateEmail(string mail)
        {
            return new IdentityError()
            {
                Code = "DuplicateEmail",
                Description = $" ilgili mail adresi: {mail} mevcuttur, lütfen farklı bir mail adresi ile kayıt olun."
            };
        }

        public override IdentityError DuplicateUserName(string userName)
        {
            return new IdentityError()
            {
                Code = "DuplicateUserName",
                Description = $" ilgili kullanıcı adı: {userName} mevcuttur, lütfen farklı bir kullanıcı adı ile kayıt olun."
            };
        }

        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "En az bir özel karakter giriniz."
            };
        }
    }
}

#pragma checksum "C:\Users\ozgen\source\repos\CRMUpSchool.UILayer\CRMUpSchool.UILayer\Views\Role\UserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fffb89d52279f9b1b589509f4d25c6fa69277cea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_UserList), @"mvc.1.0.view", @"/Views/Role/UserList.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ozgen\source\repos\CRMUpSchool.UILayer\CRMUpSchool.UILayer\Views\_ViewImports.cshtml"
using CRMUpSchool.UILayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ozgen\source\repos\CRMUpSchool.UILayer\CRMUpSchool.UILayer\Views\_ViewImports.cshtml"
using CRMUpSchool.UILayer.Areas.Employee.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ozgen\source\repos\CRMUpSchool.UILayer\CRMUpSchool.UILayer\Views\_ViewImports.cshtml"
using CRMUpSchool.UILayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ozgen\source\repos\CRMUpSchool.UILayer\CRMUpSchool.UILayer\Views\_ViewImports.cshtml"
using CRMUpSchool.EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fffb89d52279f9b1b589509f4d25c6fa69277cea", @"/Views/Role/UserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecf8c5cdd68660c6e1bb84178a814e1486b7da8f", @"/Views/_ViewImports.cshtml")]
    public class Views_Role_UserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ozgen\source\repos\CRMUpSchool.UILayer\CRMUpSchool.UILayer\Views\Role\UserList.cshtml"
  
    ViewData["Title"] = "UserList";
    Layout = "~/Views/Shared/_CRMLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Kullanıcı Listesi</h1>\r\n\r\n<table class=\"table table-striped\">\r\n    <tr>\r\n        <th>Kullanıcı Adı</th>\r\n        <th>Rol Ara</th>\r\n    </tr>\r\n");
#nullable restore
#line 14 "C:\Users\ozgen\source\repos\CRMUpSchool.UILayer\CRMUpSchool.UILayer\Views\Role\UserList.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\ozgen\source\repos\CRMUpSchool.UILayer\CRMUpSchool.UILayer\Views\Role\UserList.cshtml"
           Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a href=\"/Role/AssignRole/\" class=\"btn btn-dark\">Rol Ata</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 20 "C:\Users\ozgen\source\repos\CRMUpSchool.UILayer\CRMUpSchool.UILayer\Views\Role\UserList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\ozgen\source\repos\CRMUpSchool.UILayer\CRMUpSchool.UILayer\Views\EmployeeTask\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f0188a1e918ae479ef2f225ca985f83308ab73f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmployeeTask_Index), @"mvc.1.0.view", @"/Views/EmployeeTask/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f0188a1e918ae479ef2f225ca985f83308ab73f", @"/Views/EmployeeTask/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecf8c5cdd68660c6e1bb84178a814e1486b7da8f", @"/Views/_ViewImports.cshtml")]
    public class Views_EmployeeTask_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EmployeeTask>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ozgen\source\repos\CRMUpSchool.UILayer\CRMUpSchool.UILayer\Views\EmployeeTask\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_CRMLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<h3>G??rev Listesi</h3>

<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Ba??l??k</th>
        <th>Durum</th>
        <th>Tarih</th>
        <th>Personel</th>
        <th>G??ncelle</th>
        <th>Sil</th>
        <th>Detaylar</th>
    </tr>
");
#nullable restore
#line 22 "C:\Users\ozgen\source\repos\CRMUpSchool.UILayer\CRMUpSchool.UILayer\Views\EmployeeTask\Index.cshtml"
     foreach (var item in Model)
    {
        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\ozgen\source\repos\CRMUpSchool.UILayer\CRMUpSchool.UILayer\Views\EmployeeTask\Index.cshtml"
           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\ozgen\source\repos\CRMUpSchool.UILayer\CRMUpSchool.UILayer\Views\EmployeeTask\Index.cshtml"
           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\ozgen\source\repos\CRMUpSchool.UILayer\CRMUpSchool.UILayer\Views\EmployeeTask\Index.cshtml"
           Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\ozgen\source\repos\CRMUpSchool.UILayer\CRMUpSchool.UILayer\Views\EmployeeTask\Index.cshtml"
           Write(item.Date.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\ozgen\source\repos\CRMUpSchool.UILayer\CRMUpSchool.UILayer\Views\EmployeeTask\Index.cshtml"
           Write(item.AppUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 30 "C:\Users\ozgen\source\repos\CRMUpSchool.UILayer\CRMUpSchool.UILayer\Views\EmployeeTask\Index.cshtml"
                              Write(item.AppUser.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a href=\"#\" class=\"btn btn-outline-warning\">G??ncelle</a></td>\r\n            <td><a href=\"#\" class=\"btn btn-outline-danger\">Sil</a></td>\r\n            <td><a href=\"#\" class=\"btn btn-outline-dark\">Detaylar</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 35 "C:\Users\ozgen\source\repos\CRMUpSchool.UILayer\CRMUpSchool.UILayer\Views\EmployeeTask\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<a href=\"/EmployeeTask/AddTask/\" class=\"btn btn-outline-primary\">Yeni G??rev Giri??i</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EmployeeTask>> Html { get; private set; }
    }
}
#pragma warning restore 1591

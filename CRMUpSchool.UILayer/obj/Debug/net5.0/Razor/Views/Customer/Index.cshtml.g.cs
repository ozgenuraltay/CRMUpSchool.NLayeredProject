#pragma checksum "C:\Users\ozgen\source\repos\CRMUpSchool.UILayer\CRMUpSchool.UILayer\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "535c83bc87380d6872d8c8097011d6bdb8423acc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
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
using CRMUpSchool.UILayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ozgen\source\repos\CRMUpSchool.UILayer\CRMUpSchool.UILayer\Views\Customer\Index.cshtml"
using CRMUpSchool.EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"535c83bc87380d6872d8c8097011d6bdb8423acc", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a9ef5452ce209f118ab9ccf2be361ff61051306", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ozgen\source\repos\CRMUpSchool.UILayer\CRMUpSchool.UILayer\Views\Customer\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\ozgen\source\repos\CRMUpSchool.UILayer\CRMUpSchool.UILayer\Views\Customer\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 9 "C:\Users\ozgen\source\repos\CRMUpSchool.UILayer\CRMUpSchool.UILayer\Views\Customer\Index.cshtml"
  Write(item.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "C:\Users\ozgen\source\repos\CRMUpSchool.UILayer\CRMUpSchool.UILayer\Views\Customer\Index.cshtml"
                     Write(item.CustomerSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 10 "C:\Users\ozgen\source\repos\CRMUpSchool.UILayer\CRMUpSchool.UILayer\Views\Customer\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
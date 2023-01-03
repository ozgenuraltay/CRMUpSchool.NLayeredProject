#pragma checksum "C:\Users\ozgen\source\repos\CRMUpSchool.UILayer\CRMUpSchool.UILayer\Areas\Admin\Views\AdminCustomer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9114c3f931514dd91e16ce4fc2986b7813c1352a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminCustomer_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminCustomer/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9114c3f931514dd91e16ce4fc2986b7813c1352a", @"/Areas/Admin/Views/AdminCustomer/Index.cshtml")]
    public class Areas_Admin_Views_AdminCustomer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ozgen\source\repos\CRMUpSchool.UILayer\CRMUpSchool.UILayer\Areas\Admin\Views\AdminCustomer\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_CRMLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script src=""//ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js""></script>

<h1>Müşteri Ajax İşlemleri</h1>
<br />
<button type=""button"" id=""btnCustomerList"" class=""btn btn-outline-dark"">Müşteri Listesi</button>
<button type=""button"" id=""btnCustomerAdd"" class=""btn btn-outline-success"">Müşteri Ekle</button>
<button type=""button"" id=""btnCustomerGet"" class=""btn btn-outline-primary"">Müşteri Getir</button>
<button type=""button"" id=""btnCustomerUpdate"" class=""btn btn-outline-warning"">Müşteri Güncelle</button>
<button type=""button"" id=""btnCustomerDelete"" class=""btn btn-outline-danger"">Müşteri Sil</button>
<br />
<br />

<div id=""customerList"">

</div>
<br />
<br />

<div class=""form-group"">
    <input type=""text"" id=""txtCustomerName"" placeholder=""Müşteri adını giriniz."" class=""form-control"" />
    <br />
    <input type=""text"" id=""txtCustomerSurname"" placeholder=""Müşteri soyadını giriniz."" class=""form-control"" />
    <br />
    <input type=""text"" id=""txtCustomerMail"" placeholder=""Müşt");
            WriteLiteral(@"eri mailini giriniz."" class=""form-control"" />
    <br />
    <input type=""text"" id=""txtCustomerPhone"" placeholder=""Müşteri telefonunu giriniz."" class=""form-control"" />
    <br />

</div>
<br />
<br />

<div class=""form-group"">
    <input type=""text"" placeholder=""Aranacak ID değerini giriniz."" id=""txtId"" class=""form-control"" />
</div>
<br />
<div id=""customerGetById"">

</div>


<script>
    $(""#btnCustomerList"").click(function () {
        $.ajax({
            contentType: ""application/json"",
            dataType: ""json"",
            type: ""get"",
            url: ""/Admin/AdminCustomer/CustomerList/"",
            success: function (fonk1) {
                let values = jQuery.parseJSON(fonk1);
                console.log(values);

                let tableHtml = ""<table class='table table-bordered'> <tr><th>Müşteri ID</th><th>Müşteri Adı</th><th>Müşteri Soyadı</th><th>Müşteri Mail</th></tr>"";

                $.each(values, (index, item) => {
                    tableHtml += `<tr");
            WriteLiteral(@"><td>${item.CustomerID}</td> <td>${item.CustomerName}</td> <td>${item.CustomerSurname}</td><td>${item.CustomerMail}</td></tr>`
                });

                tableHtml += ""</table>"";
                $(""#customerList"").html(tableHtml);
            }
        });
    });

    $(""#btnCustomerAdd"").click(function () {
        let customerValues = {
            CustomerName: $(""#txtCustomerName"").val(),
            CustomerSurname: $(""#txtCustomerSurname"").val(),
            CustomerMail: $(""#txtCustomerMail"").val(),
            CustomerPhone: $(""#txtCustomerPhone"").val(),
        };

        $.ajax({
            dataType: ""json"",
            type: ""post"",
            data: customerValues,
            url: ""/Admin/AdminCustomer/AddCustomer/"",
            success: function (fonk2) {
                let values = jQuery.parseJSON(fonk2);
                alert(""Müşteri başarılı bir şekilde eklendi."");
            }
        });
    })


    $(""#btnCustomerGet"").click(function () {
  ");
            WriteLiteral(@"      let id = $(""#txtId"").val();

        $.ajax({
            contentType: ""application/json"",
            dataType: ""json"",
            type: ""get"",
            data: { CustomerID: id },
            url: ""/Admin/AdminCustomer/GetByID/"",
            success: function (fonk3) {
                let values = jQuery.parseJSON(fonk3);
                console.log(values);


                let tableHtml2 = `<table class='table table-bordered'><tr><th>Müşteri ID</th><th>Müşteri Adı</th><th>Müşteri Soyadı</th></tr><tr><td>${values.CustomerID}</td><td>${values.CustomerName}</td><td>${values.CustomerSurname}</td></tr></table>`;
                $(""#customerGetById"").html(tableHtml2);
            }
        });


    })


</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

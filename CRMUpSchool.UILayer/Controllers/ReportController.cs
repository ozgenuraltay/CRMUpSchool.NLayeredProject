using ClosedXML.Excel;
using CRMUpSchool.DataAccessLayer.Concretee;
using CRMUpSchool.UILayer.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CRMUpSchool.UILayer.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult ReportList()
        {
            return View();
        }

        //Static Excel Listesi
        public IActionResult ExcelStatic()
        {
            ExcelPackage excelPackage = new ExcelPackage();
            var workSheet = excelPackage.Workbook.Worksheets.Add("Sayfa1");
            workSheet.Cells[1, 1].Value = "PersonelID";
            workSheet.Cells[1, 2].Value = "Personel Adı";
            workSheet.Cells[1, 3].Value = "Personel Soyadı";

            workSheet.Cells[2, 1].Value = "0001";
            workSheet.Cells[2, 2].Value = "Özge Nur";
            workSheet.Cells[2, 3].Value = "Altay";

            workSheet.Cells[3, 1].Value = "0002";
            workSheet.Cells[3, 2].Value = "Serap";
            workSheet.Cells[3, 3].Value = "Beran";

            var bytes = excelPackage.GetAsByteArray();

            return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Personeller.xlsx");
        }

        public List<CustomerViewModel> CustomerList()
        {
            List<CustomerViewModel> customerViewModels = new List<CustomerViewModel>();
            using (var context = new Context())
            {
                customerViewModels = context.Customers.Select(x => new CustomerViewModel
                {
                    CustomerMail = x.CustomerMail,
                    CustomerName = x.CustomerName,
                    CustomerSurname = x.CustomerSurname,
                    CustomerPhone = x.CustomerPhone
                }).ToList();
            }
            return customerViewModels;
        }

        public IActionResult DynamicExcel()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Müşteri Listesi");
                workSheet.Cell(1, 1).Value = "Mail Adresi";
                workSheet.Cell(1, 2).Value = "Müşteri Adı";
                workSheet.Cell(1, 3).Value = "Müşteri Soyadı";
                workSheet.Cell(1, 4).Value = "Müşteri Telefon";

                int rowCount = 2; //ilk satır başlıkları içeriyor.
                foreach (var item in CustomerList())
                {
                    workSheet.Cell(rowCount, 1).Value = item.CustomerMail;
                    workSheet.Cell(rowCount, 2).Value = item.CustomerName;
                    workSheet.Cell(rowCount, 3).Value = item.CustomerSurname;
                    workSheet.Cell(rowCount, 4).Value = item.CustomerPhone;
                    rowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet","MüşteriListesi.xlsx");
                }

            }
        }

        public IActionResult StaticPDFReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PDFReports/" + "Musteri.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);
            document.Open();
            Paragraph paragraph = new Paragraph("UpSchool .Net Full Stack Backend Proje");
            document.Add(paragraph);
            document.Close();

            return File("/PDFReports/Musteri.pdf","application/pdf","Musteri.pdf");
        }
    }
}

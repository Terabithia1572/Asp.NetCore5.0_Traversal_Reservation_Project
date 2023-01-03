using Asp.NetCore5._0_Traversal_Reservation_Project.Models;
using BusinessLayer.Abstract;
using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_Traversal_Reservation_Project.Controllers
{
    public class ExcelController : Controller
    {
        private readonly IExcelService _excelService;

        public ExcelController(IExcelService excelService)
        {
            _excelService = excelService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public List<DestinationModel> DestinationList()
        {
            List<DestinationModel> destinationModels = new();
            using (var context=new Context())
            {
                destinationModels = context.Destinations.Select(x => new DestinationModel
                {
                    City = x.City,
                    DayNight = x.DayNight,
                    Price = x.Price,
                    Capacity = x.Capacity
                }).ToList();
            }
            return destinationModels;
        }

        public IActionResult StaticExcelReport()
        {
            //ExcelPackage excelPackage = new();
            //var workSheet = excelPackage.Workbook.Worksheets.Add("Sayfa1");
            //workSheet.Cells[1, 1].Value = "Rota";
            //workSheet.Cells[1, 2].Value = "Rehber";
            //workSheet.Cells[1, 3].Value = "Kontenjan";

            //workSheet.Cells[2, 1].Value = "Gurcistan,Batum Turu";
            //workSheet.Cells[2, 2].Value = "Yunus İNAN";
            //workSheet.Cells[2, 3].Value = "30";

            //workSheet.Cells[2, 1].Value = "Sırbistan - Makedonya Turu";
            //workSheet.Cells[2, 2].Value = "Zeynep Öztürk";
            //workSheet.Cells[2, 3].Value = "50";

            //var bytes = excelPackage.GetAsByteArray();
            //return File(bytes, "application/vnd.openxmlformats-officedocument-spreadsheetml.sheet", "dosya.xlsx");

            return File(_excelService.ExcelList(DestinationList()), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "YeniExcel.xlsx");
            //application/vnd.openxmlformats-officedocument.spreadsheetml.sheet
        }

        public IActionResult DestinationExcelReport()
        {
            using (var workBook=new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Tur Listesi");
                workSheet.Cell(1, 1).Value = "Şehir";
                workSheet.Cell(1, 2).Value = "Konaklama Süresi";
                workSheet.Cell(1, 3).Value = "Fiyat";
                workSheet.Cell(1, 4).Value = "Kapasite";

                int rowCount = 2;

                foreach (var item in DestinationList())
                {
                    workSheet.Cell(rowCount, 1).Value = item.City;
                    workSheet.Cell(rowCount, 2).Value = item.DayNight;
                    workSheet.Cell(rowCount, 3).Value = item.Price;
                    workSheet.Cell(rowCount, 4).Value = item.Capacity;
                    rowCount++;
                }

                using (var stream =new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument-spreadsheetml.sheet", "YeniListe.xlsx");
                }
            }
           
        }
    }
}

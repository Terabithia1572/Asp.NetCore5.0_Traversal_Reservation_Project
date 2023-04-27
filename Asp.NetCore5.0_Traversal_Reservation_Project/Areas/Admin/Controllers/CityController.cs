using Asp.NetCore5._0_Traversal_Reservation_Project.Models;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_Traversal_Reservation_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;
        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(_destinationService.TGetList());
            return Json(jsonCity);
        }

        [HttpPost]
        public IActionResult AddCityDestination(Destination destination)
        {
            destination.Status = true;
            _destinationService.TAdd(destination);
            var values =JsonConvert.SerializeObject(destination);
            return Json(values);
        }

        public IActionResult GetByID(int id)
        {
            var values = _destinationService.GetByID(id);
            var jsonValues = JsonConvert.SerializeObject(values);
            return Json(jsonValues);
        }

    //    public static List<CityClass> cities = new List<CityClass>
    //{
    //    new CityClass
    //    {
    //        CityID=1,
    //        CityName="Üsküp",
    //        CityCountry="Makedonya"
    //    },
    //    new CityClass
    //    {
    //        CityID=2,
    //        CityName="Roma",
    //        CityCountry="İtalya"
    //    },
    //    new CityClass
    //    {
    //        CityID=3,
    //        CityName="İstanbul",
    //        CityCountry="Türkiye"
    //    }
    // };


    }
}


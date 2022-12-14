using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_Traversal_Reservation_Project.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new(new EfDestinationRepository());
        public IActionResult Index()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }
    }
}

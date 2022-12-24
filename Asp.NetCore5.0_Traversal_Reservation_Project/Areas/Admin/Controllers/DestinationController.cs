using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_Traversal_Reservation_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

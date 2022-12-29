using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_Traversal_Reservation_Project.ViewComponents.AdminDashboard
{
    public class _Cards1Statistic:ViewComponent
    {
        Context context = new();
        public IViewComponentResult Invoke()
        {
            ViewBag.TurSayisi = context.Destinations.Count();
            ViewBag.MisafirSayisi = context.Users.Count();
            return View();
        }
    }
}

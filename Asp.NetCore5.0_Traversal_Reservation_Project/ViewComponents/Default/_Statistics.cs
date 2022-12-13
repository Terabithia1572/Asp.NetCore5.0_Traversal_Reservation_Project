using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_Traversal_Reservation_Project.ViewComponents.Default
{
    public class _Statistics:ViewComponent
    {
        Context context = new();
        
        public IViewComponentResult Invoke()
        {
            Random r = new Random();
            int sayi1 = r.Next(1, 999);
            int sayi2 = r.Next(1, 999);
           ViewBag.destinationsCount= context.Destinations.Count();
            ViewBag.travelGuide = context.Guides.Count();
            ViewBag.happyCustomer = sayi1;
            ViewBag.Awards = sayi2;
            return View();
        }
    }
}

using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_Traversal_Reservation_Project.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        ContactUsManager contactUsManager = new(new EfContactUsRepository());
        public IActionResult Index()
        {
            var values = contactUsManager.TGetList();
            return View();
        }
    }
}

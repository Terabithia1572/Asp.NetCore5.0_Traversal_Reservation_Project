using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_Traversal_Reservation_Project.ViewComponents.Default
{
    public class _SubAbout:ViewComponent
    {
        SubAboutManager subAboutManager = new(new EfSubAboutRepository());
        public IViewComponentResult Invoke()
        {
            var values=subAboutManager.TGetList();
            return View(values);
        }
    }
}

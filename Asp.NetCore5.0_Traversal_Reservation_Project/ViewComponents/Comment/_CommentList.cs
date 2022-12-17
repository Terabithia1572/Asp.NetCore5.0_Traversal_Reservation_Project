using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_Traversal_Reservation_Project.ViewComponents.Comment
{
    public class _CommentList:ViewComponent
    {
        CommentManager commentManager = new(new EfCommentRepository());
        public IViewComponentResult Invoke(int id) // 
        {
            var values = commentManager.TGetDestinationByID(id);
            return View(values);
        }
    }
}

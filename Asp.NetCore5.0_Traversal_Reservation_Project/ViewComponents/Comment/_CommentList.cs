﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_Traversal_Reservation_Project.ViewComponents.Comment
{
    public class _CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

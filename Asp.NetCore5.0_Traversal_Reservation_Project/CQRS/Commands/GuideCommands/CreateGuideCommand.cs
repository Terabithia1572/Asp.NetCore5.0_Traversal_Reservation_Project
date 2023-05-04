﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_Traversal_Reservation_Project.CQRS.Commands.GuideCommands
{
    public class CreateGuideCommand:IRequest
    {
        public string GuideName { get; set; }
        public string GuideDescription { get; set; }
    }
}

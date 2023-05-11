﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRApi.Model
{
    public class VisitorCharts
    {
        public VisitorCharts()
        {
            Counts = new List<int>();
        }
        public string VisitDate { get; set; }
        public List<int> Counts { get; set; }
    }
}

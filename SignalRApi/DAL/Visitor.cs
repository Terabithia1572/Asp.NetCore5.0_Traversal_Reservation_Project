using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRApi.DAL
{
    public enum Ecity
    {
        Van = 1,
        İstanbul = 2,
        Ankara = 3,
        Antalya = 4,
        Şırnak = 5
    }
    public class Visitor
    {
        public int VisitorID { get; set; }
        public Ecity City { get; set; }
        public int CityVisitCount { get; set; }
        public DateTime VisitDate { get; set; }

    }
}

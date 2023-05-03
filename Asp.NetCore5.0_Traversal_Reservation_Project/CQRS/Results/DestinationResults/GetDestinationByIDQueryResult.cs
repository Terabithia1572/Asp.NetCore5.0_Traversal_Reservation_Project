using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_Traversal_Reservation_Project.CQRS.Results.DestinationResults
{
    public class GetDestinationByIDQueryResult
    {
        public int DestinationID { get; set; }
        public string City { get; set; }
        public string DayNight { get; set; }
    }
}

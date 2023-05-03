using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_Traversal_Reservation_Project.CQRS.Results.DestinationResults
{
    public class GetAllDestinationQueryResult
    {
        public int ID { get; set; }
        public string city { get; set; }
        public string daynight { get; set; }
        public double price { get; set; }
        public int capacity { get; set; }
    }
}

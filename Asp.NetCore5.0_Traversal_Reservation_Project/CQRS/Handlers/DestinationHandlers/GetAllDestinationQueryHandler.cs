using Asp.NetCore5._0_Traversal_Reservation_Project.CQRS.Queries.DestinationQueries;
using Asp.NetCore5._0_Traversal_Reservation_Project.CQRS.Results.DestinationResults;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_Traversal_Reservation_Project.CQRS.Handlers.DestinationHandlers
{
    public class GetAllDestinationQueryHandler
    {
        private readonly Context _context;

        public GetAllDestinationQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetAllDestinationQueryResult> Handle()
        {
            var values = _context.Destinations.Select(x => new GetAllDestinationQueryResult
            {

                ID = x.DestinationID,
                city=x.City,
                capacity = x.Capacity,
                daynight = x.DayNight,
                price = x.Price

            }).AsNoTracking().ToList();

            return values;

        }
    }
}

using Asp.NetCore5._0_Traversal_Reservation_Project.CQRS.Results.GuideResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_Traversal_Reservation_Project.CQRS.Queries.GuideQueries
{
    public class GetGuideByIDQuery:IRequest<GetGuideByIDQueryResult>
    {
        public GetGuideByIDQuery(int id)
        {
            ID = id;
        }

        public int ID { get; set; }
    }
}

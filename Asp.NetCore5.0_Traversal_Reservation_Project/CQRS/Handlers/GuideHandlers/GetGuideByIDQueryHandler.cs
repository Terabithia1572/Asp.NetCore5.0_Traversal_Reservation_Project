using Asp.NetCore5._0_Traversal_Reservation_Project.CQRS.Queries.GuideQueries;
using Asp.NetCore5._0_Traversal_Reservation_Project.CQRS.Results.GuideResults;
using DataAccessLayer.Concrete;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_Traversal_Reservation_Project.CQRS.Handlers.GuideHandlers
{
    public class GetGuideByIDQueryHandler : IRequestHandler<GetGuideByIDQuery, GetGuideByIDQueryResult>
    {
        private readonly Context _context;

        public GetGuideByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetGuideByIDQueryResult> Handle(GetGuideByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Guides.FindAsync(request.ID);
            return new GetGuideByIDQueryResult
            {
                GuideID = values.GuideID,
                GuideDescription = values.GuideDescription,
                GuideName = values.GuideName
            };
        }
    }
}

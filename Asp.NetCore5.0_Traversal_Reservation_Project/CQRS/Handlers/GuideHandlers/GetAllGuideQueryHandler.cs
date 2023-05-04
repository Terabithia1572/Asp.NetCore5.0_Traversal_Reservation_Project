using Asp.NetCore5._0_Traversal_Reservation_Project.CQRS.Queries.GuideQueries;
using Asp.NetCore5._0_Traversal_Reservation_Project.CQRS.Results.GuideResults;
using DataAccessLayer.Concrete;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_Traversal_Reservation_Project.CQRS.Handlers.GuideHandlers
{
    public class GetAllGuideQueryHandler:IRequestHandler<GetAllGuideQuery,List<GetAllGuideQueryResult>>
    {
        private readonly Context _context;

        public GetAllGuideQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetAllGuideQueryResult>> Handle(GetAllGuideQuery request, CancellationToken cancellationToken)
        {
            return await _context.Guides.Select(x => new GetAllGuideQueryResult
            {

                GuideID = x.GuideID,
                GuideDescription = x.GuideDescription,
                GuideImage = x.GuideImage,
                GuideName = x.GuideName

            }).AsNoTracking().ToListAsync();
        }
    }
}

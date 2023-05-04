using Asp.NetCore5._0_Traversal_Reservation_Project.CQRS.Commands.GuideCommands;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_Traversal_Reservation_Project.CQRS.Handlers.GuideHandlers
{
    public class CreateGuideCommandHandler : IRequestHandler<CreateGuideCommand>
    {
        private readonly Context _context;

        public CreateGuideCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateGuideCommand request, CancellationToken cancellationToken)
        {
            _context.Guides.Add(new Guide
            {

                GuideName = request.GuideName,
                GuideDescription = request.GuideDescription,
                Status = true

            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}

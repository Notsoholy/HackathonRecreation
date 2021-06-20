using Application.Exceptions;
using Application.Interfaces;
using Application.Usecases.Queries.GetRecreationObjects;
using Application.Usecases.Queries.Mapping;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Usecases.Queries.GetRecreationObject
{
    public class GetRecreationObjectQuery : IRequest<RecreationObjectViewModel>
    {
        public Guid Id { get; }

        public GetRecreationObjectQuery(Guid id)
        {
            Id = id;
        }

        private class Handler : IRequestHandler<GetRecreationObjectQuery, RecreationObjectViewModel>
        {
            private readonly IRecreationDbContext _context;

            public Handler(IRecreationDbContext context)
            {
                _context = context;
            }

            public async Task<RecreationObjectViewModel> Handle(GetRecreationObjectQuery request, CancellationToken cancellationToken)
            {
                var recreationObject = await _context
                    .RecreationObjects
                    .Include(x => x.AdditionalServices)
                    .Include(x => x.Diseases)
                    .Include(x => x.HealingMethods)
                    .Include(x => x.Location)
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.Id == request.Id)
                    ?? throw new NotFoundException(nameof(RecreationObject), request.Id);

                return recreationObject.Map();
            }
        }
    }
}

#nullable enable

using Application.Interfaces;
using Application.Usecases.Queries.Mapping;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Usecases.Queries.GetRecreationObjects
{
    public class GetRecreationObjectsQuery : IRequest<ICollection<RecreationObjectViewModel>>
    {
        public ICollection<Guid>? Locations { get; set; }

        public ICollection<Guid>? Diseases { get; set; }

        public ICollection<Guid>? HealingMethods { get; set; }

        public ICollection<Guid>? AdditionalServices { get; set; }

        public ICollection<int>? Stars { get; set; }

        private class Handler : IRequestHandler<GetRecreationObjectsQuery, ICollection<RecreationObjectViewModel>>
        {
            private readonly IRecreationDbContext _context;

            public Handler(IRecreationDbContext context)
            {
                _context = context;
            }

            public async Task<ICollection<RecreationObjectViewModel>> Handle(GetRecreationObjectsQuery request, CancellationToken cancellationToken)
            {

                var query = await _context.RecreationObjects
                    .Include(x => x.Location)
                    .Include(x => x.AdditionalServices)
                    .Include(x => x.Diseases)
                    .Include(x => x.HealingMethods)
                    .AsNoTracking()
                    .ToListAsync(cancellationToken);

                if (request.AdditionalServices is not null && request.AdditionalServices.Count > 0)
                {
                    query = query
                        .Where(x => request.AdditionalServices
                        .All(y => x.AdditionalServices
                        .Select(z => z.Id)
                        .Contains(y)))
                        .ToList();
                }

                if (request.Diseases is not null && request.Diseases.Count > 0)
                {
                    query = query
                        .Where(x => request.Diseases
                        .All(y => x.Diseases
                        .Select(z => z.Id)
                        .Contains(y)))
                        .ToList();
                }

                if (request.HealingMethods is not null && request.HealingMethods.Count > 0)
                {
                    query = query
                        .Where(x => request.HealingMethods
                        .All(y => x.HealingMethods
                        .Select(z => z.Id)
                        .Contains(y)))
                        .ToList();
                }

                if (request.Locations is not null && request.Locations.Count > 0)
                {
                    query = query.Where(x => request.Locations.Contains(x.Location.Id)).ToList();
                }

                if (request.Stars is not null && request.Stars.Count > 0)
                {
                    query = query.Where(x => request.Stars.Contains(x.Stars)).ToList();
                }

                if (query is not null)
                {
                    return query.Select(x => x.Map()).ToList();
                }

                return new List<RecreationObjectViewModel>();
            }
        }
    }
}

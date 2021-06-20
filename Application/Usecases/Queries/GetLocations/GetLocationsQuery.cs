using Application.Interfaces;
using Application.Usecases.Queries.CommonViewModels;
using Application.Usecases.Queries.Mapping;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Usecases.Queries.GetLocations
{
    public class GetLocationsQuery : IRequest<ICollection<LocationViewModel>>
    {
        private class Handler : IRequestHandler<GetLocationsQuery, ICollection<LocationViewModel>>
        {
            private readonly IRecreationDbContext _context;

            public Handler(IRecreationDbContext context)
            {
                _context = context;
            }

            public async Task<ICollection<LocationViewModel>> Handle(GetLocationsQuery request, CancellationToken cancellationToken)
            {
                var locations = await _context.Locations.AsNoTracking().ToListAsync(cancellationToken);

                if (locations.Any())
                {
                    return locations.Select(x => x.Map()).ToList();
                }

                return new List<LocationViewModel>();
            }
        }
    }
}

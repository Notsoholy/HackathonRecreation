using Application.Interfaces;
using Application.Usecases.Queries.CommonViewModels;
using Application.Usecases.Queries.Mapping;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Usecases.Queries.GetAdditionalServices
{
    public class GetAdditionalServicesQuery : IRequest<ICollection<AdditionalServiceViewModel>>
    {
        private class Handler : IRequestHandler<GetAdditionalServicesQuery, ICollection<AdditionalServiceViewModel>>
        {
            private readonly IRecreationDbContext _context;

            public Handler(IRecreationDbContext context)
            {
                _context = context;
            }

            public async Task<ICollection<AdditionalServiceViewModel>> Handle(GetAdditionalServicesQuery request, CancellationToken cancellationToken)
            {
                var additionalServices = await _context.AdditionalServices.AsNoTracking().ToListAsync(cancellationToken);

                if (additionalServices.Any())
                {
                    return additionalServices.Select(x => x.Map()).ToList();
                }

                return new List<AdditionalServiceViewModel>();
            }
        }
    }
}

using Application.Interfaces;
using Application.Usecases.Queries.CommonViewModels;
using Application.Usecases.Queries.Mapping;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Usecases.Queries.GetDiseases
{
    public class GetDiseasesQuery : IRequest<ICollection<DiseaseViewModel>>
    {
        private class Handler : IRequestHandler<GetDiseasesQuery, ICollection<DiseaseViewModel>>
        {
            private readonly IRecreationDbContext _context;

            public Handler(IRecreationDbContext context)
            {
                _context = context;
            }

            public async Task<ICollection<DiseaseViewModel>> Handle(GetDiseasesQuery request, CancellationToken cancellationToken)
            {
                var diseases = await _context.Diseases.AsNoTracking().ToListAsync(cancellationToken);

                if (diseases.Any())
                {
                    return diseases.Select(x => x.Map()).ToList();
                }

                return new List<DiseaseViewModel>();
            }
        }
    }
}

using Application.Interfaces;
using Application.Usecases.Queries.CommonViewModels;
using Application.Usecases.Queries.Mapping;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Usecases.Queries.GetHealingMethods
{
    public class GetHealingMethodsQuery : IRequest<ICollection<HealingMethodViewModel>>
    {
        private class Handler : IRequestHandler<GetHealingMethodsQuery, ICollection<HealingMethodViewModel>>
        {
            private readonly IRecreationDbContext _context;

            public Handler(IRecreationDbContext context)
            {
                _context = context;
            }

            public async Task<ICollection<HealingMethodViewModel>> Handle(GetHealingMethodsQuery request, CancellationToken cancellationToken)
            {
                var healingMethods = await _context.HealingMethods.AsNoTracking().ToListAsync(cancellationToken);

                if (healingMethods.Any())
                {
                    return healingMethods.Select(x => x.Map()).ToList();
                }

                return new List<HealingMethodViewModel>();
            }
        }
    }
}

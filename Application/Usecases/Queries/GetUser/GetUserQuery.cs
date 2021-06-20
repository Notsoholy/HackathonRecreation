using Application.Exceptions;
using Application.Interfaces;
using Application.Usecases.Queries.Mapping;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Usecases.Queries.GetUser
{
    public class GetUserQuery : IRequest<UserViewModel>
    {
        public string UserUid { get; }

        public GetUserQuery(string id)
        {
            UserUid = id;
        }

        private class Handler : IRequestHandler<GetUserQuery, UserViewModel>
        {
            private readonly IRecreationDbContext _context;

            public Handler(IRecreationDbContext context)
            {
                _context = context;
            }

            public async Task<UserViewModel> Handle(GetUserQuery request, CancellationToken cancellationToken)
            {
                var user = await _context.Users
                    .Include(x => x.UserMessages)
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.UserUid == request.UserUid, cancellationToken)
                    ?? throw new NotFoundException(nameof(User), request.UserUid);

                return user.Map();
            }
        }
    }
}

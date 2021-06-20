using Application.Exceptions;
using Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Usecases.Commands
{
    public class LoginUserCommand : IRequest
    {
        public string Id { get; }

        public LoginUserCommand(string id)
        {
            Id = id;
        }

        private class Handler : IRequestHandler<LoginUserCommand>
        {
            private readonly IRecreationDbContext _context;

            public Handler(IRecreationDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(LoginUserCommand request, CancellationToken cancellationToken)
            {
                var user = await _context.Users.FirstOrDefaultAsync(x => x.UserUid == request.Id, cancellationToken)
                    ?? throw new UserUnathorizedException($"Пользователь с идентификатором {request.Id} отсутствует в базе");

                return Unit.Value;
            }
        }
    }
}

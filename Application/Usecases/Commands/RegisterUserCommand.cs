using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Usecases.Commands
{
    public class RegisterUserCommand : IRequest
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Patronymic { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string UserUid { get; set; }

        private class Handler : IRequestHandler<RegisterUserCommand>
        {
            private readonly IRecreationDbContext _context;

            public async Task<Unit> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
            {
                var user = new User
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    Patronymic = request.Patronymic,
                    Email = request.Email,
                    Phone = request.Phone,
                    UserUid = request.UserUid
                };

                _context.Users.Add(user);

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}

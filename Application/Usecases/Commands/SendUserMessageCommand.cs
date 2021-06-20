using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Usecases.Commands
{
    public class SendUserMessageCommand : IRequest
    {
        public Guid UserId { get; set; }

        public string MessageText { get; set; }

        public string RecreationEmail { get; set; }

        private class Handler : IRequestHandler<SendUserMessageCommand>
        {
            private readonly IRecreationDbContext _context;

            public Handler(IRecreationDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(SendUserMessageCommand request, CancellationToken cancellationToken)
            {
                var userMessage = new UserMessage
                {
                    MessageText = request.MessageText,
                    RecreationEmail = request.RecreationEmail,
                    UserId = request.UserId
                };

                _context.UserMessages.Add(userMessage);

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}

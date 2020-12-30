using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OneMediatorToRuleThemAll
{
    public class RingCommandHandler : IRequestHandler<SendRingCommand, string>
    {
        public Task<string> Handle(SendRingCommand request, CancellationToken cancellationToken)
        {
            return Task.Factory.StartNew<string>(() =>
            {
                return $"Ring is moving to {request.To} from {request.From}";
            });
        }
    }
}

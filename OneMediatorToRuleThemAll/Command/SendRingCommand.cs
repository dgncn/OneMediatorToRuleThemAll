using MediatR;

namespace OneMediatorToRuleThemAll.Command
{
    public class SendRingCommand : IRequest<string>
    {
        public string From { get; set; }
        public string To { get; set; }
    }
}

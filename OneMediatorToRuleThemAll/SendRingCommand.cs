using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneMediatorToRuleThemAll
{
    public class SendRingCommand : IRequest<string>
    {
        public string From { get; set; }
        public string To { get; set; }
    }
}

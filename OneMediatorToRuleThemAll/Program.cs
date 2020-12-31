using MediatR;
using Microsoft.Extensions.DependencyInjection;
using OneMediatorToRuleThemAll.Command;
using System;
using System.Reflection;

namespace OneMediatorToRuleThemAll
{
    class Program
    {
        static void Main()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddMediatR(Assembly.GetExecutingAssembly());

            var serviceProvider = serviceCollection.BuildServiceProvider();

            var mediatorService = serviceProvider.GetService<IMediator>();
            var task = mediatorService.Send(new SendRingCommand() { From = "Frodo", To = "Sauron" });
            Console.WriteLine(task.Result);
        }
    }
}

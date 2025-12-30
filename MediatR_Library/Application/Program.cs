using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.DependencyInjection;


// Program
class Program
{
    static async Task Main(string[] args)
    {
        // Setup DI container
        var services = new ServiceCollection();

        // Register MediatR and handlers
        services.AddMediatR(typeof(Program));

        var provider = services.BuildServiceProvider(); // now works

        // Get Mediator
        var mediator = provider.GetRequiredService<IMediator>();

        // Send command
        await mediator.Send(new Multiply(5, 7));
    }
}

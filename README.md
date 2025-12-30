

MEDIATOR

It is design pattern

It acts as a middleman between different parts of a application. 

Instead of objects talking to each other directly, they sends messages to the Mediator  

and the mediator sends them to the correct handler. 


UI / Client

    |

    v

[Mediator] ---> CommandHandler ---> Service / Domain logic

    |

    v

[Mediator] ---> QueryHandler ---> Data / Read logic

==>   UI sends a command or query to the mediator. 

==> The mediator finds the correct handler

==> The handler executes the logic and returns a result for queries. 


We can use MediatR Library to implement this. 

MediatR

MediatR is simplifies the implementation of the Mediator Pattern.

It allows you to define requests (commands and queries ) and their corresponding handlers separately


CQRS And MediatR : Step-by-Step
http://medium.com/@araxis/implementing-cqrs-with-mediatr-library-step-by-step-sample-code-2fde29a0afaf




Step 1: Create a command:


A command class should implement the IRequest interface provided by the MediatR library. Here is a sample command class:


public record Add(int a, int b): IRequest< int>;



Step 2: Create Command Handler 

The next step is to create a command handler class. The command handler class is responsible for executing the command. A command handler class should implement the IRequestHandler interface provided by the MediatR library and should have a constructor that takes in the dependencies it requires. Here is a sample command handler class


public class AddHandler:IRequestHandler<Add, int>

{

   

    public Task<int> Handle (Add request, CancellationToken cancellationToken)

    {

       

        int res= request.a + request.b;

        Console.WriteLine($"{res}");

        return Task.FromResult(res);

    }



}



Step 3: Register


services.AddMediatR(typeof(Program));

Step 4: Execute the Command

Finally, we can execute the command by sending it to the mediator using the Send method provided by the MediatR library. Here is an example of executing the:


mediator.Send(new Multiply(5, 7));



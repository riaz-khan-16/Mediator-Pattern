
using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

// Handler
public class SayHelloHandler : IRequestHandler<SayHelloCommand, Unit>
{
    public Task<Unit> Handle(SayHelloCommand request, CancellationToken cancellationToken)
    {
        Console.WriteLine("Hello World");
        return Task.FromResult(Unit.Value);
    }
}


public class HiHandler: IRequestHandler<HiCommand, Unit>
{
    public Task<Unit> Handle (HiCommand request, CancellationToken cancellationToken)
    {
        
        Console.WriteLine("Hi Riaz");
        return Task.FromResult(Unit.Value);
        
    }


}

public class SquareHandler: IRequestHandler<Square, int>

{

    public Task<int> Handle (Square request, CancellationToken cancellationToken)
    {
        
        int res= request.Number * request.Number;
        System.Console.WriteLine($"{res}");
        return Task.FromResult(res);
    }
    

}


public class AddHandler:IRequestHandler<Add, int>
{
    
    public Task<int> Handle (Add request, CancellationToken cancellationToken)
    {
        
        int res= request.a + request.b;
        Console.WriteLine($"{res}");
        return Task.FromResult(res);
    }
    

}



public class SubtractHandler: IRequestHandler<Subtract, int>
{
    
    public Task<int> Handle (Subtract request, CancellationToken cancellationToken)
    {
        
        int res=request.a-request.b;
        Console.WriteLine($"{res}");
        return Task.FromResult(res);
    }
}



public class MultiplicationHandler:IRequestHandler<Multiply, int>
{
    
    public Task<int> Handle (Multiply request, CancellationToken cancellationToken)
    {
        
        int res=request.a*request.b;
        Console.WriteLine($"{res}");
        return Task.FromResult(res);
    }
}
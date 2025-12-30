using MediatR;

public class SquareNumberHandler
    : IRequestHandler<SquareNumberCommand, int>
{
    public Task<int> Handle(
        SquareNumberCommand request,
        CancellationToken cancellationToken)
    {
        int result = request.Number * request.Number;
        return Task.FromResult(result);
    }
}


public class AddHandler : IRequestHandler<Add, int>
{

    public Task<int> Handle(
        Add request,
        CancellationToken cancellationToken)
    {
        int result = request.a +  request.b;
        return Task.FromResult(result);
    }

}



public class SubHandler : IRequestHandler<Subtract, int>
{

    public Task<int> Handle(
        Subtract request,
        CancellationToken cancellationToken)
    {
        int result = request.a -  request.b;
        return Task.FromResult(result);
    }

}
using MediatR;

public record SquareNumberCommand(int Number) : IRequest<int>;

public record Add(int a, int b): IRequest<int>;


public record Subtract(int a, int b) : IRequest<int>;
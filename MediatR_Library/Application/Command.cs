// Command

using System.Net;
using MediatR;

public record SayHelloCommand() : IRequest<Unit>;  /// 
public record HiCommand(): IRequest<Unit>;

public record Square(int Number): IRequest<int>;  // it will return an integer

public record Add(int a, int b): IRequest< int>;

public record Subtract(int a, int b): IRequest<int>; 

public record Multiply(int a, int b): IRequest<int>;

using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class MathController : ControllerBase
{
    private readonly IMediator _mediator;

    public MathController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("square/{number}")]
    public async Task<IActionResult> Square(int number)
    {
        var command = new SquareNumberCommand(number);

        int result = await _mediator.Send(command);

        return Ok(result);
    }


    [HttpGet("add/{a}/{b}")]
    public async Task<IActionResult> Adding(int a, int b)
    {
        var command = new Add(a, b);

        int result = await _mediator.Send(command);

        return Ok(result);
    }

    [HttpGet("sub/{a}/{b}")]
    public async Task<IActionResult> Subtracting(int a, int b)
    {
        var command = new Subtract(a, b);

        int result = await _mediator.Send(command);

        return Ok(result);
    }
}
public class SayHelloHandler
{
    public string Handle(SayHelloCommand<string> command)
    {
        return $"Hello, {command.Name}!";
    }
}


public class SayHiHandler
{
    public string Handle(SayHiCommand<string> command)
    {
        return $"Hi, {command.Name}!";
    }
}



public class ShowValueHandler
{
    public string Handle(ShowValueCommand<int> command)
    {
        return $" {command.Value*2}!";
    }
}
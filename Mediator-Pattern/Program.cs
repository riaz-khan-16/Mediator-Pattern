class Program
{
    static void Main()
    {
         // register the handlers
          var mediator = new Mediator(
            new SayHelloHandler(),
            new SayHiHandler(),
            new ShowValueHandler()

        );


        // write command and send to mediator , it will automatically find handler
        var command = new ShowValueCommand<int> (888888888);

        string  result = mediator.Send(command);

        Console.WriteLine(result);
    }
}

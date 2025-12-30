public class Mediator
{
    private readonly SayHelloHandler _helloHandler;
    private readonly SayHiHandler _hiHandler;
    private readonly ShowValueHandler _showValueHandler;
   

    public Mediator(SayHelloHandler hellohandler, SayHiHandler hiHandler, ShowValueHandler showValueHandler)
    {
         _helloHandler=hellohandler;
         _hiHandler=hiHandler;
         _showValueHandler=showValueHandler;
        
    }

    public string Send(SayHelloCommand<string> command)
    {
        // Mediator decides which handler to call
        return _helloHandler.Handle(command);
    }
     public string Send(SayHiCommand<string> command)
    {
        // Mediator decides which handler to call
        return _hiHandler.Handle(command);

        
    }

    public string Send(ShowValueCommand<int> command)
    {
        // Mediator decides which handler to call
        return _showValueHandler.Handle(command);

        
    }

     
}

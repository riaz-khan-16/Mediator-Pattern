public record SayHelloCommand<T>(T Name);
public record SayHiCommand<T>(T Name);
public record ShowValueCommand<T>(T Value);


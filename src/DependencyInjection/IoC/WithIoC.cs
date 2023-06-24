namespace DependencyInjection.IoC.Implementation;

internal class WithIoC
{
}


public class ProductService
{
    private readonly ILogger _logger;

    public ProductService(ILogger logger)
    {
        _logger = logger;
    }

    public void Log(string message)
    {
        _logger.Log(message);
    }
}

public interface ILogger
{
    void Log(string message);
}

public class FileLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine("Inside Log method of FileLogger.");
        LogToFile(message);
    }
    private void LogToFile(string message)
    {
        Console.WriteLine("Method: LogToFile, Text: {0}", message);
    }
}

public class DatabaseLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine("Inside Log method of DatabaseLogger.");
        LogToDatabase(message);
    }
    private void LogToDatabase(string message)
    {
        Console.WriteLine("Method: LogToDatabase, Text: {0}", message);
    }
}
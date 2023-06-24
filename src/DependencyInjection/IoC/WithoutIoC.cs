namespace DependencyInjection.IoC.Violation;

internal class WithoutIoC
{
}

public class ProductService
{
    private readonly FileLogger _fileLogger = new FileLogger();
    private readonly DatabaseLogger _databaseLogger = new DatabaseLogger();

    public void LogToFile(string message)
    {
        _fileLogger.Log(message);
    }
    public void LogToDatabase(string message)
    {
        _databaseLogger.Log(message);
    }

}

public class FileLogger
{
    public void Log(string message)
    {
        Console.WriteLine("Inside Log method of FileLogger");
        LogToFile(message);
    }

    private void LogToFile(string message)
    {
        Console.WriteLine($"Method: LogToFile, text: {message}");
    }
}

public class DatabaseLogger
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
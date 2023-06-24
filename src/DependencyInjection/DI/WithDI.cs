namespace DependencyInjection.DI.With;

/// <summary>
/// There is three types of DI [Constructor, Method, and Setter]
/// </summary>
internal class WithDI
{
}


public class ClientService
{
    private ClientRepository _clientRepository;
    
    /// <summary>
    /// Constructor Dependency Injection
    /// </summary>
    /// <param name="clientRepository"></param>
    public ClientService(ClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    /// <summary>
    /// Method Dependency Injection
    /// </summary>
    /// <param name="logger"></param>
    public void LogOperation(Logger logger)
    {
    }

    // Rest of the class
}

public class ClientRepository
{
    // Client Repository implementations
}

public class Logger
{
    // Logger implementation
}


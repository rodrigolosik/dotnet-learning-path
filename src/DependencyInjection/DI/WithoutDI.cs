namespace DependencyInjection.DI.Without;

internal class WithoutDI
{
}

public class ClientService
{
    private ClientRepository clienteRepository = new ClientRepository();

    // Rest of implementation
}

public class ClientRepository
{
    // Client repository implementation
}
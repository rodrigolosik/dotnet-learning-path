using System.Data.SqlClient;
using System.Data;
using System.Net.Mail;

namespace SOLID.Principles.DependencyInversionPrinciple.Implementation;

internal class DIPImplementation
{
}

public class Cliente
{
    public int ClienteId { get; set; }
    public string Nome { get; set; }
    public Email Email { get; set; }
    public Cpf Cpf { get; set; }
    public DateTime DataCadastro { get; set; }

    public bool Validar()
    {
        return Email.Validar() && Cpf.Validar();
    }
}

public class ClienteRepository : IClienteRepository
{
    public void AdicionarCliente(Cliente cliente)
    {

        using (var cn = new SqlConnection())
        {
            var cmd = new SqlCommand();

            cn.ConnectionString = "MinhaConnectionString";
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO CLIENTE (NOME, EMAIL CPF, DATACADASTRO) VALUES (@nome, @email, @cpf, @dataCad))";

            cmd.Parameters.AddWithValue("nome", cliente.Nome);
            cmd.Parameters.AddWithValue("email", cliente.Email);
            cmd.Parameters.AddWithValue("cpf", cliente.Cpf);
            cmd.Parameters.AddWithValue("dataCad", cliente.DataCadastro);

            cn.Open();
            cmd.ExecuteNonQuery();
        }

    }
}

public class ClienteRepository2 : IClienteRepository
{
    public void AdicionarCliente(Cliente cliente)
    {

        // Usar outra forma de ir até o BD

    }
}

public class ClienteServices : IClienteServices
{
    private readonly IClienteRepository _clienteRepository;
    private readonly IEmailServices _emailServices;

    public ClienteServices(
        IEmailServices emailServices,
        IClienteRepository clienteRepository)
    {
        _emailServices = emailServices;
        _clienteRepository = clienteRepository;
    }

    public string AdicionarCliente(Cliente cliente)
    {
        if (!cliente.Validar())
            return "Dados inválidos";

        _clienteRepository.AdicionarCliente(cliente);

        _emailServices.Enviar("empresa@empresa.com", cliente.Email.Endereco, "Bem Vindo", "Parabéns está Cadastrado");

        return "Cliente cadastrado com sucesso";
    }
}

public class TesteDip
{
    public TesteDip()
    {
        var cliService = new ClienteServices(new EmailServices(), new ClienteRepository2());
    }
}

public class Cpf
{
    public string Numero { get; set; }

    public bool Validar()
    {
        return Numero.Length == 11;
    }
}

public class Email
{
    public string Endereco { get; set; }

    public bool Validar()
    {
        return Endereco.Contains("@");
    }
}

public class EmailServices : IEmailServices
{
    public void Enviar(string de, string para, string assunto, string mensagem)
    {
        var mail = new MailMessage(de, para);
        var client = new SmtpClient
        {
            Port = 25,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Host = "smtp.google.com"
        };

        mail.Subject = assunto;
        mail.Body = mensagem;
        client.Send(mail);
    }
}

public interface IClienteRepository
{
    void AdicionarCliente(Cliente cliente);
}

public interface IClienteServices
{
    string AdicionarCliente(Cliente cliente);
}

public interface IEmailServices
{
    void Enviar(string de, string para, string assunto, string mensagem);
}
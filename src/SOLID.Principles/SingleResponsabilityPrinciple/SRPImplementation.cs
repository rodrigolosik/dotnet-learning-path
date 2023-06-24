using System.Data;
using System.Data.SqlClient;

namespace SOLID.Principles.SingleResponsabilityPrinciple.Implementation;

internal class SRPImplementation
{
}

public class Client
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

public class Cpf
{
    public bool Validar() { return false; }
}

public class Email
{
    public string Endereco { get; set; }
    public bool Validar() { return false; }
}

public class ClienteRepository
{
    public void AdicionarCliente(Client cliente)
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

public class ClienteService
{
    public string AdicionarCliente(Client cliente)
    {
        if (!cliente.Validar())
            return "Dados inválidos";

        var repo = new ClienteRepository();
        repo.AdicionarCliente(cliente);

        EmailServices.Enviar("empresa@empresa.com",
                             cliente.Email.Endereco,
                             "Bem Vindo",
                             "Parabéns está Cadastrado");

        return "Cliente cadastrado com sucesso";
    }
}

public static class EmailServices
{
    public static void Enviar(string email, string endereco, string titulo, string mensagem)
    {
    }
}

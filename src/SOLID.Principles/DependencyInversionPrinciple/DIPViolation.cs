﻿using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace SOLID.Principles.DependencyInversionPrinciple.Violation;

internal class DIPViolation
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


public class ClienteRepository
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

public class ClienteService
{
    public string AdicionarCliente(Cliente cliente)
    {
        if (!cliente.Validar())
            return "Dados inválidos";

        var repo = new ClienteRepository();
        repo.AdicionarCliente(cliente);

        EmailServices.Enviar("empresa@empresa.com", cliente.Email.Endereco, "Bem Vindo", "Parabéns está Cadastrado");

        return "Cliente cadastrado com sucesso";
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

public static class EmailServices
{
    public static void Enviar(string de, string para, string assunto, string mensagem)
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
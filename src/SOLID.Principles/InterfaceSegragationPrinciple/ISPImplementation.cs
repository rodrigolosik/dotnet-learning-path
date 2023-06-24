namespace SOLID.Principles.InterfaceSegragationPrinciple.Implementation;

internal class ISPImplementation
{
}

public class CadastroProduto : ICadastroProduto
{
    public void ValidarDados()
    {
        // Validar valor
    }

    public void SalvarBanco()
    {
        // Insert tabela Produto
    }
}

public class CadastroCliente : ICadastroCliente
{
    public void ValidarDados()
    {
        // Validar CPF, Email
    }

    public void SalvarBanco()
    {
        // Insert na tabela Cliente
    }

    public void EnviarEmail()
    {
        // Enviar e-mail para o cliente
    }
}

public interface ICadastroProduto : ICadastro
{
    void ValidarDados();
}

public interface ICadastroCliente : ICadastro
{
    void ValidarDados();
    void EnviarEmail();
}

public interface ICadastro
{
    void SalvarBanco();
}
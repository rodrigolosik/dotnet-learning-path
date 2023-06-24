namespace SOLID.Principles.OpenClosePrinciple.Violation;

internal class OCPViolation
{
}

public class DebitoConta
{
    public void Debitar(decimal valor, string conta, TipoConta tipoConta)
    {
        if (tipoConta == TipoConta.Corrente)
        {
            // Debita Conta Corrente
        }

        if (tipoConta == TipoConta.Poupanca)
        {
            // Valida Aniversário da Conta
            // Debita Conta Poupança
        }
    }
}

public enum TipoConta
{
    Corrente,
    Poupanca,
}
namespace Flags.Console;

public enum CorSemFlag // enumerador comum
{
    Vermelho = 1,
    Verde = 2,
    Azul = 4,
    Amarelo = 8
}

[Flags]
public enum Cor // usando flags, basta adicionar o atributo
{
    Vermelho = 1,
    Verde = 2,
    Azul = 4,
    Amarelo = 8
}


// declaração errada com valores padrões
//[Flags]
//public enum Cor
//{
//    Vermelho, // valor padrão 0
//    Verde,    // valor padrão 1
//    Azul,     // valor padrão 2
//    Amarelo   // valor padrão 3
//}

//// declaração errada com atribuição de valores não sequênciais na base 2^x
//[Flags]
//public enum Cor
//{
//    Vermelho = 1,
//    Verde = 2,
//    Azul = 3,
//    Amarelo = 4
//}

//// declaração correta
//[Flags]
//public enum Cor
//{
//    Vermelho = 1,
//    Verde = 2,
//    Azul = 4,
//    Amarelo = 8
//}

//// declaração correta, usando bit-shifting 
//[Flags]
//public enum Cor
//{
//    None = 0,
//    Vermelho = 1 << 0,
//    Verde = 1 << 1,
//    Azul = 1 << 2,
//    Amarelo = 1 << 3
//}
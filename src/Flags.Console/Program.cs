using Flags.Console;

CorSemFlag minhasCores = CorSemFlag.Vermelho | CorSemFlag.Verde | CorSemFlag.Azul;
Cor minhasCoresFlags = Cor.Vermelho | Cor.Verde | Cor.Azul;

Console.WriteLine(minhasCores);
Console.WriteLine(minhasCoresFlags);

Cor novasCores = Enum.Parse<Cor>("Vermelho, Verde, Azul"); // Funcionará e irá atribuir corretamente os valores

var cores = Cor.Verde | Cor.Vermelho;

var resultado1 = cores.HasFlag(Cor.Verde); // true

var resultado2 = cores.HasFlag(Cor.Vermelho); // true

var resultado3 = cores.HasFlag(Cor.Amarelo); // false

var resultado4 = cores.HasFlag(Cor.Verde | Cor.Vermelho); // true, pois contém os dois

var resultado5 = cores.HasFlag(Cor.Verde) && cores.HasFlag(Cor.Vermelho); // true, mesma coisa que a expressão acima

var resultado6 = cores.HasFlag(Cor.Verde | Cor.Amarelo); // false, pois um elemento não está no conjunto

var resultado7 = cores.HasFlag(Cor.Verde) || cores.HasFlag(Cor.Amarelo); // true, por que contém pelo menos um


// Para .NET 4 (também funcionará para as versões mais atualizadas, porém a "escrita" é "pior"

var resultado8 = ((cores & Cor.Verde) == Cor.Verde); // true, pois a cor Verde está em cores 
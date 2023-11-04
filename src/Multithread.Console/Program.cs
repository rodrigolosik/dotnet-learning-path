using System.Collections.Concurrent;

ConcurrentDictionary<int, int> concurrent = new ConcurrentDictionary<int, int>();
var queue = new ConcurrentQueue<int>();
var stack = new ConcurrentStack<int>();

List<int> list = new List<int>();
ConcurrentBag<int> bag = new ConcurrentBag<int>();

var numThreads = 4;

Task[] tasks = new Task[numThreads];

for (int i = 0; i < tasks.Length; i++)
{
    tasks[i] = Task.Factory.StartNew(() =>
    {
        for (int j = 0; j < 10; j++)
        {
            Console.WriteLine($"J: {j}");
            bag.Add(j);
            list.Add(j);
        }
    });
}

// Esperar até que todas as threads tenham terminado
Task.WaitAll(tasks);

// Verificar quantos elementos foram adicionados à lista
Console.WriteLine($"Total de elementos na bag: {bag.Count}");
Console.WriteLine($"Total de elementos na lista: {list.Count}");

Console.ReadLine();
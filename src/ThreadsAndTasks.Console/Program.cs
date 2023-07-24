#region Threads
//Thread thread = new Thread(ImprimirNumeros);
//thread.Start();

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("Main: " + i);
//    Thread.Sleep(500);
//}
#endregion

#region Tasks
Task task = ImprimirNumerosAsync();

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Main: " + i);
    Task.Delay(500).Wait();
}

await task;
#endregion

/// Thread
static void ImprimirNumeros()
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Thread: " + i);
        Thread.Sleep(1000);
    }
}

/// Task
static async Task ImprimirNumerosAsync()
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Task: " + i);
        await Task.Delay(1000);
    }
}
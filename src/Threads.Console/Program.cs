internal class Program
{
    private const int loops = 5;
    private bool ok;

    private static void Main(string[] args)
    {
        // Cria uma instância comum
        Program tt = new Program();
        //inicia a execução da rotina na nova instância
        new Thread(tt.NovaThread).Start();
        //executa a rotina na mesma instãncia
        tt.NovaThread();
        Console.ReadKey();
    }

    void NovaThread()
    {
        if (!ok)
        {
            ok = true;
            Console.WriteLine("www.macoratti.net");
        }
    }

    #region 1
    //private static void Main(string[] args)
    //{
    //    Thread t = new Thread(NovaThread);
    //    t.Start();

    //    for (int i = 0; i < loops; i++) { Console.Write("1"); }

    //}

    //private static void NovaThread()
    //{
    //    for (int i = 0; i < loops; i++) { Console.Write("2"); }
    //}
    #endregion

    #region 2
    //private static void Main(string[] args)
    //{
    //    new Thread(NovaThread).Start();
    //    NovaThread();
    //    Console.ReadKey();
    //}

    //static void NovaThread()
    //{
    //    for (int i = 0; i < loops; i++)
    //    {
    //        Console.Write(i);
    //    }
    //}
    #endregion

}


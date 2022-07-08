internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("=========================================");
        Console.WriteLine("..:::| C.R.O.N.O.M.E.T.R.O |:::..");
        Console.WriteLine("=========================================");
        Console.WriteLine("Selecione abaixo uma opção:");
        Console.WriteLine("");
        Console.WriteLine("S = Segundos => 10s é o mesmo que 10 segundos");
        Console.WriteLine("");
        Console.WriteLine("M = Minutos => 10m é o mesmo que 10 minutos");
        Console.WriteLine("");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("");
        Console.WriteLine("Quanto tempo deseja contar?");
        Console.WriteLine("");

        //ToLower manter a entrada de dado sempre minusculo
        //Length pega o tamanho de uma sequencia
        string data = Console.ReadLine().ToLower();
        char type = char.Parse(data.Substring(data.Length - 1, 1));
        int time = int.Parse(data.Substring(0, data.Length - 1));
        int multiplier = 1;

        if (type == 'm')
            multiplier = 60;

        if (time == 0)
            System.Environment.Exit(0);

        PreStart(time * multiplier);


    }

    static void PreStart(int time)
    {
        Console.Clear();
        Console.WriteLine("Ready. . . ");
        Thread.Sleep(1000);
        Console.WriteLine("Set . . . ");
        Thread.Sleep(1000);
        Console.WriteLine("GO . . . ");
        Thread.Sleep(2500);
        Start(time);

    }

    static void Start(int time)
    {
        int currentTime = 0;

        //enquanto currentTime for diferente do time .. execute o while
        while (currentTime != time)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }
        Console.Clear();
        Console.WriteLine("Stopwacth finalizado");
        Thread.Sleep(2500);
        Menu();

    }

}
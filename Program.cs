using System;

namespace Calculator
{

    class Program
    {

        static void Main(string[] args)
        {
            menu();
        }

        static void menu()
        {
            Console.Clear();
            Console.WriteLine("s - segundos => 10s = 10 segundos");
            Console.WriteLine("m - minutos => 1m = 1 minuto");
            Console.WriteLine("0 - sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                System.Environment.Exit(0);

            preStart(time * multiplier);
        }

        static void preStart (int time){
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(1000);

            start(time);

        }
        static void start(int time)
        {
            int currentTime = 0;

            while (currentTime < time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finalizado!");
            Thread.Sleep(2500);

        }
    }
}
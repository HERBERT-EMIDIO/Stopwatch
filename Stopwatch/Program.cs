using System;
using System.Threading;
namespace Stopwatch
{
    class program
    {
        static void Main(string[] args)
        {

            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower(); //ToLower converte para letras minúsculas
            char type = char.Parse(data.Substring(data.Length - 1, 1)); // data.length - 1 para pegar o ultimo caractere
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
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
        }
        static void Start(int time)
        {

            int currentTime = 0;

            while (currentTime != time)
            {
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000); //dormir por 1s

                Console.Clear();
                Console.WriteLine("Stopwatch finalizado...");
                Thread.Sleep(1000);
            }
        }
    }
}
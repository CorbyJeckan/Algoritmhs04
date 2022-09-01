using Algoritmhs04;
using System;


namespace Algorithms
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Title = "Algorithms";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Здравствуйте!\nПожалуйста,введите пункт и подпункт для выбора домашнего задания.\nДоступные для выбора пункты:\n1 - Протестируйте поиск строки в HashSet и в массиве.\n2 - Реализуйте DFS и BFS для дерева с выводом каждого шага в консоль.");
            string selectednumber = (Console.ReadLine());
            switch (selectednumber)
            {
                case "1":
                    {
                        HashSet.MainHash();
                    }
                    break;

                case "2":
                    {
                        Pprogram.MainTwo();

                    }
                   break;



            }
        }
    }

}

using System;
namespace Uppgift4._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många x per grupp?");
            string antalxtext = Console.ReadLine();
            int antalx = int.Parse(antalxtext);
            Console.WriteLine("Hur många o per grupp?");
            string antalotext = Console.ReadLine();
            int antalo = int.Parse(antalotext);
            Console.WriteLine("Hur många o mönster per rad?");
            string antaloradertext = Console.ReadLine();
            int antalorader = int.Parse(antaloradertext);
            Console.WriteLine("Hur många rader ska skrivas ut?");
            string antalradertext = Console.ReadLine();
            int antalrader = int.Parse(antalradertext);

            for(int i = 0; i < antalrader; i++)
            {
                for(int j = 0; j < antalx; j++)
                {
                    Console.Write("X");
                }
                for(int k = 0; k < antalorader; k++)
                {
                    Console.Write("-");
                    for (int l = 0; l < antalo; l++)
                    {
                        Console.Write("O");
                    }
                    Console.Write("-");
                    for (int m = 0; m < antalx; m++)
                    {
                        Console.Write("X");
                    }
                    
                }        
            Console.WriteLine();
            }
        Console.ReadKey();    
        }   
    }
}
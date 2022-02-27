using System;
using System.Collections.Generic;
using System.Linq;

namespace DesgloseMonedas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserte un Amount para imprimir el desglose de billetes.");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n <= 0)
            {
                Console.WriteLine("El Amount debe ser mayor que 0");
                Console.WriteLine("Intente otra vez");
                n = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("**************************************");
            printAmountBreakdown(n);
            Console.WriteLine("**************************************");
            Console.WriteLine("Completado.");
            Console.ReadKey();
        }

        private static void printAmountBreakdown(int n)
        {
            int number = n;
            List<int> breakdowns = new List<int>() { 2000, 1000, 500, 200, 100, 50, 25, 10, 5, 1 };
            
            foreach (var breakdown in breakdowns.Where(x => x <= n))
            {
                if (number == 0) return;
                if (number >= breakdown)
                {
                    int times = number / breakdown;
                    int result = times * breakdown;
                    Console.WriteLine($"{times} x {breakdown} = {result}");
                    number = number - result;
                }
            }
        }
    }
}

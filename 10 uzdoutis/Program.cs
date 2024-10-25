using System;

namespace PirmaPaskaita1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite skaiciu");
            int n = int.Parse(Console.ReadLine());
            int r = n;

            while (r <= 1000)
            {
                Console.WriteLine($"dabartinis rezultatas {r}:");
               
                r *= 2;

                
            }
            Console.WriteLine($"galutinis rezultatas virsijantis 1000 {r}");
        }
    }
}
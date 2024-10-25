using System;

namespace penkioliktauzdoutis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Įveskite pirmąjį skaičių:");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Įveskite prieaugį:");
            int D = int.Parse(Console.ReadLine());

            Console.WriteLine("Įveskite norimą progresijos ilgį:");
            int I = int.Parse(Console.ReadLine());

            Console.WriteLine("Aritmetinė progresija:");

            for (int i = 0; i < I; i++)
            {
                int t = A + i * D;

                if (t > 100)
                {
                    break;
                }

                Console.WriteLine(t);
            }
        }
    }
}

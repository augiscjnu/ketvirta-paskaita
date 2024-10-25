using System;

namespace tryliktauzdoutis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Įveskite teigiamą skaičių:");
            int n = int.Parse(Console.ReadLine());

            
            if (n <= 0)
            {
                Console.WriteLine("Skaičius turi būti teigiamas.");
                return;
            }

            int c = 0;

            
            while (n > 0)
            {
                n /= 10; 
                c++; 
            }

            Console.WriteLine($"Skaičius turi {c} skaitmenų.");
        }
    }
}

using System;

namespace SekosAugimas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Įveskite pradžios skaičių: ");
            int s = int.Parse(Console.ReadLine());

            Console.Write("Įveskite prieaugį: ");
            int D = int.Parse(Console.ReadLine());

            while (s <= 500)
            {
                
                if (s % 2 == 0)
                {
                    int H = s *= 2; 
                }

                Console.WriteLine(s);

                s += D; 
            }
        }
    }
}
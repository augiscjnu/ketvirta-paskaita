using System;

namespace tryliktauzdoutis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Įveskite sveikąjį skaičių:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int s = i * i;

                if (s > 200)
                {
                    break;
                }

                Console.WriteLine($" skaiciaus kvadratas = {s}");
            }
        }
    }
}

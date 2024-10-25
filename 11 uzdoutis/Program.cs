using System;

namespace venuoliktauzdoutis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("pirminai  skaicai nuo 2 iki 50:");

            for (int n = 2; n <= 50; n++)
            {
                bool Y = true;

                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        Y = false;
                        break;
                    }
                }

                if (Y)
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}
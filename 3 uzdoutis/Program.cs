using System;

namespace treciauzdoutis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Įveskite skaičių {0}: ", i + 1);
                int n = Convert.ToInt32(Console.ReadLine());

                
                switch (n % 2)
                {
                    case 0:
                        Console.WriteLine("Skaičius {0} yra lyginis.", n);
                        break;
                    case 1:
                        Console.WriteLine("Skaičius {0} yra nelyginis.", n);
                        break;
                }
            }
        }
    }
}
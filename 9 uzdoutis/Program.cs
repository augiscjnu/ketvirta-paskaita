using System;

namespace PirmaPaskaita1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n;

            while (true)
            {
                Console.WriteLine("Įveskite bet kokį sveikąjį skaičių (0 norint baigti):");
                n = int.Parse(Console.ReadLine());

                if (n == 0)
                {
                    Console.WriteLine("Programa baigta.");
                    break;
                }
                else if (n > 0)
                {
                    Console.WriteLine("Įvestas skaičius yra teigiamas.");
                }
                else
                {
                    Console.WriteLine("Įvestas skaičius yra neigiamas.");
                }
            }
        }
    }
}
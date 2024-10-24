using System;

namespace ketvirtapskaita
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Įveskite skaičių: ");
                int number = Convert.ToInt32(Console.ReadLine());

                
                if (number > 0)
                {
                    Console.WriteLine("Teigiamas");
                }
                else if (number < 0)
                {
                    Console.WriteLine("Neigiamas");
                }
                
            }
        }
    }
}
           

            

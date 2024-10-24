using System;

namespace septintazudoutis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            int c = 0;
            int n;

            while (true)
            {
                n = r.Next(1, 11); 
                c++;

                

                if (n == 7)
                {
                    break;
                }
            }

            Console.WriteLine($"i viso sugenerouti skaiciai iki 7: {c}");
        }
    }
}
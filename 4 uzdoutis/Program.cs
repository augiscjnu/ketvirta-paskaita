using System;

namespace ketvirtauzdoutis
{
    public class Program
    {
        public static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Įveskite skaičių : ", i + 1);
                int a = Convert.ToInt32(Console.ReadLine());


                switch (a) 
                { 
                 case int n when (n < 0):
                    Console.WriteLine("Neigiamas skaičius");
                    break;
                case int n when (n >= 1 && n <= 10):
                    Console.WriteLine("skaicius yra Mažas");
                    break;
                case int n when (n >= 11 && n <= 100):
                    Console.WriteLine("skaicius yra Vidutinis");
                    break;
                case int n when (n > 100):
                    Console.WriteLine("skaicius yra Didelis");
                    break;
                }
            }
        }
    }
}
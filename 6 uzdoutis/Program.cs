namespace sestauzdoutis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lyginių skaičių radimas nuo 1 iki 50:");
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0) 
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
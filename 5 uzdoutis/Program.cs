namespace penktauzdoutis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Įveskite skaičių:");
            int number = Convert.ToInt32(Console.ReadLine());

            
            for (int i = 1; i <= 10; i++)
            {
                int result = number * i;

                
                if (result > 50)
                {
                    break;
                }

                
                Console.WriteLine($"{number} x {i} = {result}");
            }
        }
    }
}
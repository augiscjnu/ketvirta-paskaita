namespace penktauzdoutis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Įveskite skaičių:");
            int n = Convert.ToInt32(Console.ReadLine());

            
            for (int i = 1; i <= 10; i++)
            {
                int r = n * i;

                
                if (r > 50)
                {
                    break;
                }

                
                Console.WriteLine($"{n} x {i} = {r}");
            }
        }
    }
}
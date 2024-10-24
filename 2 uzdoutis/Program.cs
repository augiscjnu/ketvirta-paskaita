namespace antrauzdoutis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] n = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Įveskite {i + 1} skaičių:");
                n[i] = Convert.ToInt32(Console.ReadLine());
            }

            
            int d = n[0];
            for (int i = 1; i < n.Length; i++)
            {
                if (n[i] > d)
                {
                    d = n[i];
                }
            }

            Console.WriteLine($"Didžiausias skaičius: {d}");

            
           
                
            
        }
    }
}
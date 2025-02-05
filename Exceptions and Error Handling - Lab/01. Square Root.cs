namespace ExceptionHandling
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            try
            {
                if(a < 0)
                {
                    throw new ArgumentException("Invalid number.");
                }
                else
                {
                    Console.WriteLine(Math.Sqrt(a));
                }
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }     
        }
    }
}
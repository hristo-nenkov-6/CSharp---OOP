using System.Runtime.CompilerServices;

namespace EnterNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int end = 10;
            int previousNumber = 1;
            for (int i = 0; i < end; i++)
            {
                try
                {
                    previousNumber = ReadNumber(list, previousNumber);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    end++;
                }
            }
            Console.WriteLine(String.Join(", ", list));
        }
        public static int ReadNumber(List<int> numbers, int previousNumber)
        {
            string a = Console.ReadLine();
            if(int.TryParse(a, out int result))
            {
                if (result > previousNumber && result < 100)
                {
                    numbers.Add(result);
                    previousNumber = result;
                }
                else
                {
                    throw new ArgumentException($"Your number is not in range {previousNumber} - 100!");
                }
            }
            else
            {
                throw new ArgumentException("Invalid Number!");
            }

            return previousNumber;
        }
    }
}
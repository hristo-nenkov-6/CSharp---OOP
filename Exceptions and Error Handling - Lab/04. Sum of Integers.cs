using System.Text;
using System.Text.Unicode;
using System.Xml.Linq;

namespace Cards
{
    public class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split();
            long sum = 0;
            foreach (var line in input)
            {
                try
                {
                    sum = ProcessNumbers(sum, line);
                }
                catch(OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException exF)
                { 
                    Console.WriteLine($"The element '{line}' is in wrong format!");
                }
                finally
                {
                    Console.WriteLine($"Element '{line}' processed - current sum: {sum}");
                }
            }
            Console.WriteLine($"The total sum of all integers is: {sum}");
        }
        static long ProcessNumbers(long sum, string line)
        {
            if (int.TryParse(line.Trim(), out int value))
            {
                sum += value;
            }
            else if(long.Parse(line) > int.MaxValue)
            {
                throw new OverflowException($"The element '{line}' is out of range!");
            }
            else
            {
                throw new FormatException($"The element '{line}' is in wrong format!");
            }
            return sum;
        }
    }
}
using System.Text;
using System.Text.Unicode;

namespace Cards
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Card> list = new List<Card>();
            Console.OutputEncoding = Encoding.UTF8;
            var input = Console.ReadLine().Split(", ");
            foreach (var line in input)
            {
                string face = line.Split()[0];
                string suit = line.Split()[1];

                try
                {
                    Card card = new Card(face, suit);
                    list.Add(card);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(String.Join(" ", list));
        }
    }
    public class Card
    {
        private string face;
        private string suit;

        public Card(string face, string suit)
        {
            Face = face;
            Suit = suit;
        }

        public string Face
        {
            get => face;
            set
            {
                switch (value)
                {
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    case "10":
                    case "J":
                    case "Q":
                    case "K":
                    case "A":
                        {
                            face = value;
                            break;
                        }
                    default:
                        {
                            throw new ArgumentException("Invalid card!");
                        }
                }
            }
        }
        public string Suit
        {
            get => suit;
            set
            {
                switch (value)
                {
                    case "S":
                    case "H":
                    case "D":
                    case "C":
                        {
                            suit = value;
                            break;
                        }
                    default:
                        {
                            throw new ArgumentException("Invalid card!");
                        }
                }
            }
        }
        public override string ToString()
        {
            string output = string.Empty;
            switch(Suit)
            {
                case "S":
                    {
                        output = $"[{face}\u2660]";
                        break;
                    }
                case "H":
                    {
                        output = $"[{face}\u2665]";
                        break;
                    }
                case "D":
                    {
                        output = $"[{face}\u2666]";
                        break;
                    }
                case "C":
                    {
                        output = $"[{face}\u2663]";
                        break;
                    }
            }
            return output;
        }
    }
}
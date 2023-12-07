namespace SpokenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool onOff = true;
            Console.WriteLine("Please enter a number up to 4 digits and the program will write out the number in words.");
            string numberIn = Console.ReadLine();

            while (onOff)
            {
                switch (numberIn.Length)
                {
                    case 1:
                        {
                            int numCon = Convert.ToInt16(numberIn);
                            Console.WriteLine(NumberSpeak.SingleDigit(numCon));
                            break;
                        }

                    case 2:
                        {
                            int numCon = Convert.ToInt16(numberIn);
                            Console.WriteLine(NumberSpeak.DoubleDigit(numCon));
                            break;
                        }

                    case 3:
                        {
                            int numCon = Convert.ToInt16(numberIn);
                            Console.WriteLine(NumberSpeak.TripleDigit(numCon));
                            break;
                        }

                    case 4:
                        {
                            int numCon = Convert.ToInt16(numberIn);
                            Console.WriteLine(NumberSpeak.FourDigit(numCon));
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Invalid!");
                            break;
                        }
                }
                if (!onOff)
                {
                    break;
                }
                Console.WriteLine("Please enter another number up to 4 digits.");
                numberIn = Console.ReadLine();
            }
        }
    }
}

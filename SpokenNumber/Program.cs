namespace SpokenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] singleDigitArray = ["Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"];
            string[] tenDigitArray = ["", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"];
            string[] teensDigitArray = ["Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"];

            bool onOff = true;
            string numberIn;
            Console.WriteLine("Please enter a number up to 4 digits.");
            numberIn = Console.ReadLine();

            while (onOff)
            {
                switch (numberIn.Length)
                {
                    case 1:
                        {
                            int numCon = Convert.ToInt16(numberIn);
                            Console.WriteLine(singleDigitArray[numCon]);
                            break;
                        }

                    case 2:
                        {
                            int numCon = Convert.ToInt16(numberIn);
                            if (numCon < 20)
                            {
                                numCon -= 10;
                                Console.WriteLine(teensDigitArray[numCon]);
                            }
                            else if (numCon % 10 == 0)
                            {
                                Console.WriteLine(tenDigitArray[numCon / 10]);
                            }
                            else
                            {
                                Console.WriteLine($"{tenDigitArray[numCon / 10]} {singleDigitArray[numCon % 10]}");
                            }
                            break;
                        }

                    case 3:
                        {
                            int numCon = Convert.ToInt16(numberIn);
                            Console.Write($"{singleDigitArray[numCon / 100]} Hundred ");
                            if (numCon % 100 > 0 & numCon % 100 < 10)
                            {
                                Console.WriteLine($"and {singleDigitArray[numCon % 100]}");
                            }
                            else if ((numCon / 10) % 10 == 1)
                            {
                                Console.WriteLine($"and {teensDigitArray[numCon % 10]}");
                            }
                            else if ((numCon / 10) % 10 <= 9 & (numCon / 10) % 10 > 0)
                            {
                                Console.WriteLine($"and {tenDigitArray[(numCon / 10) % 10]} {singleDigitArray[numCon % 10]}");
                            }
                            else
                                Console.WriteLine();

                            break;
                        }

                    case 4:
                        {
                            int numCon = Convert.ToInt16(numberIn);
                            Console.Write($"{singleDigitArray[numCon / 1000]} Thousand ");
                            numCon %= 1000;

                            if (numCon > 0 & numCon < 100)
                            {
                                if (numCon>0 &numCon<10)
                                {
                                    Console.WriteLine($"and {singleDigitArray[numCon]}");

                                }
                                else if (numCon < 20)
                                {
                                    numCon -= 10;
                                    Console.WriteLine($"and {teensDigitArray[numCon]}");
                                }
                                else if (numCon % 10 == 0)
                                {
                                    Console.WriteLine(tenDigitArray[numCon / 10]);
                                }
                                else
                                {
                                    Console.WriteLine($"{tenDigitArray[numCon / 10]} {singleDigitArray[numCon % 10]}");
                                }
                            }
                            else if (numCon>=100 & numCon < 1000)
                            {
                                Console.Write($"{singleDigitArray[numCon / 100]} Hundred ");
                                if (numCon % 100 > 0 & numCon % 100 < 10)
                                {
                                    Console.WriteLine($"and {singleDigitArray[numCon % 100]}");
                                }
                                else if ((numCon / 10) % 10 == 1)
                                {
                                    Console.WriteLine($"and {teensDigitArray[numCon % 10]}");
                                }
                                else if ((numCon / 10) % 10 <= 9 & (numCon / 10) % 10 > 0)
                                {
                                    Console.WriteLine($"and {tenDigitArray[(numCon / 10) % 10]} {singleDigitArray[numCon % 10]}");
                                }
                            }
                            Console.WriteLine();
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Invalid!\n\nGoodbye");
                            onOff = true;
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

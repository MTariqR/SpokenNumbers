using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SpokenNumber
{
    internal class NumberSpeak
    {
        public static string[] singleDigitArray = ["", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"];
        public static string[] tenDigitArray = ["", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"];
        public static string[] teensDigitArray = ["Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"];

        public static string SingleDigit(int num)
        {
            if (num == 0)
            {
                return "Zero";
            }
            else
                return singleDigitArray[num];
        }

        public static string DoubleDigit(int num)
        {
            string words ="";

            if (num < 20)
            {
                num %= 10;
                words += teensDigitArray[num];
            }
            else
            {
                words += tenDigitArray[num / 10] + ' ' + singleDigitArray[num % 10];
            }
            return words;
        }

        public static string TripleDigit(int num)
        {
            string words = $"{singleDigitArray[num / 100]} Hundred";
            
            num %= 100;
            if (num == 0)
            {
                return words;
            }
            if (num < 10)
            {
                words += $" and {singleDigitArray[num]}";
            }
            else if (num >= 10 & num < 20)
            {
                num -= 10;
                words += $" and {teensDigitArray[num]}";
            }
            else if (num % 10 == 0)
            {
                words += $" and {tenDigitArray[num / 10]}";
            }
            else
            {
                words += $" and {tenDigitArray[num / 10]} {singleDigitArray[num % 10]}";
            }

            return words;
        }

        public static string FourDigit(int num)
        {
            string words = $"{singleDigitArray[num / 1000]} Thousand";

            num %= 1000;

            if (num == 0)
            {
                return words;
            }

            if (num > 0 & num < 100)
            {
                if (num > 0 & num < 10)
                {
                    words += $" and {singleDigitArray[num]}";

                }
                else if (num < 20)
                {
                    num -= 10;
                    words += $" and {teensDigitArray[num]}";
                }
                else if (num % 10 == 0)
                {
                    words += $" and {tenDigitArray[num / 10]}";
                }
                else
                {
                    words += $" {tenDigitArray[num / 10]} {singleDigitArray[num % 10]}";
                }
            }
            else 
            {
                words += $" {singleDigitArray[num / 100]} Hundred";

                num %= 100;

                if (num == 0)
                {
                    return words;
                }

                if (num < 10)
                {
                    num %= 10;
                    words += $" and {singleDigitArray[num]}";
                }
                else if (num < 20)
                {
                    num %= 10;
                    words += $" and {teensDigitArray[num]}";
                }
                else if (num % 10 == 0)
                {
                    words += $" and {tenDigitArray[num / 10]}";
                }
                else
                {
                    words += $" and {tenDigitArray[num / 10]} {singleDigitArray[num % 10]}";
                }
            }
            return words;
        }
    }
}

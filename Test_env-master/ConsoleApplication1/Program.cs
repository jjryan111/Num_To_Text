using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int input = 1;
                Console.WriteLine("Enter Number");
                bool inp = int.TryParse(Console.ReadLine(), out input);
                //Console.WriteLine(GetNum(input));
                BreakUpNum(input);
            }
        }
        public static void BreakUpNum(int input)
        {
            List<string> textNums = new List<string>();
            int whatPlace = 0;
            while (input >= 1000)
            {
                Console.WriteLine(input%1000);
                textNums.Add(GetNum(input%1000));
                input = input / 1000;
                whatPlace++;
                
            }
            textNums.Add(GetNum(input));
            for (int i = (textNums.Count -1); i>-1; i--)
            {
                Console.Write(textNums[i] + " "+GetHundredPlus(whatPlace)+" ");
                whatPlace--;
            }
            Console.WriteLine();
        }
        public static string GetNum (int input)
        {
            string result = "";
            string dash = "-";
            int ones = input % 10;
            int tens = input % 100;
            int hundreds = input / 100;
            string onesDigit;
            string tensDigit;
            if (input > 99)
            {
                result =  GetOnes(hundreds) + " Hundred ";
                
            }
            if (tens >= 10 && tens < 20)
            {
                tens = tens % 10;
                result = result + GetTeens(tens);
            }
            else if (tens >= 20)
            {
                tens = tens / 10;
                onesDigit = GetOnes(ones);
                tensDigit = GetTens(tens);
                if (ones == 0)
                {
                    dash = "";
                }
                result = result + tensDigit + dash + onesDigit;
            }
            else
            {
                onesDigit = GetOnes(ones);
                result = result + onesDigit;
            }
            return result;
        }
        public static string GetOnes(int num)
        {

            string[] ones = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            return ones[num];
        }
        public static string GetTeens(int num)
        {
            string[] teens = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            return teens[num];
        }
        public static string GetTens (int num)
        {
            num -= 2;
            string[] tens = { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            return tens[num];
        }
        public static string GetHundredPlus(int place)
        {
            string[] places = { "", "Thousand", "Million", "Billion", "Trillion","Quadrillion" };
            return places[place];
        }
    }
}

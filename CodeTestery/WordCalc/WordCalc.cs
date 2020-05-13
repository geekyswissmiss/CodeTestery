using System;

namespace WordCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter args:");
                String input = Console.ReadLine();
                //split input on comma to get two values
                String[] splitInput = input.Split(',');
                int factor1 = int.Parse(splitInput[0]);
                if (1 > factor1 || factor1 > 5)
                {
                    Exception ex = new Exception("D should be between 1 and 5.");
                    throw ex;
                }
                String factor2 = splitInput[1].Trim('"');
                WordCalc wordCalc = new WordCalc(factor1, factor2);
                Console.WriteLine(wordCalc.Multiply().ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    public class WordCalc
    {
        public int numberOne;
        public String numberTwo;

        public WordCalc(int one, String two)
        {
            numberOne = one;
            numberTwo = two;
        }

        private int StringToInt(String number)
        {
            int result = 0;

            try
            {
                switch (number.ToUpper())
                {
                    case "ZERO":
                        result = 0;
                        break;
                    case "ONE":
                        result = 1;
                        break;
                    case "TWO":
                        result = 2;
                        break;
                    case "THREE":
                        result = 3;
                        break;
                    case "FOUR":
                        result = 4;
                        break;
                    case "FIVE":
                        result = 5;
                        break;
                    case "SIX":
                        result = 6;
                        break;
                    case "SEVEN":
                        result = 7;
                        break;
                    case "EIGHT":
                        result = 8;
                        break;
                    case "NINE":
                        result = 9;
                        break;
                    default:
                        result = 0;
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        public int Multiply()
        {
            int result = 0;
            try
            {
                result = numberOne * StringToInt(numberTwo);
            }
            catch (Exception ex)
            {
                //ruh roh
            }
            return result;
        }
    }
}

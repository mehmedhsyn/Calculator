using System;

namespace Add_Substract
{
    class Program
    {
        static decimal Calculate(decimal number1, decimal number2, string operation)
        {
            if (operation == "+")
            {
                return Add(number1, number2);
            }
            else if (operation == "-")
            {
                return Substract(number1, number2);
            }
            
            else
            {
                return 0;
            }
        }
         static decimal Substract(decimal number1, decimal number2)
         {
            return number1 - number2;
         }

        static decimal Add(decimal number1, decimal number2)
        {
            return number1 + number2;
        }

        static void Main(string[] args)
        {
            decimal number1 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            decimal number2 = int.Parse(Console.ReadLine());

            decimal result = Calculate(number1, number2, operation);
            Console.WriteLine(result);

        }
    }
}
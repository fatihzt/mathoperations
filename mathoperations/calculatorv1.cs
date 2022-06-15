using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathoperations
{
    public class calculatorv1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------");
            Console.WriteLine("Calculator Vol1");
            Console.WriteLine("--------------");

            Console.WriteLine("For addition press '+' ");
            Console.WriteLine("For substracting press '-' ");
            Console.WriteLine("For multiplying press '*' ");
            Console.WriteLine("For dividing press '/' ");

            Console.Write("Enter a number:");
            var value1 = Console.ReadLine();

            Console.Write("Enter an another number :");
            var value2 = Console.ReadLine();

            Console.Write("Enter an operation:");
            char operation = Convert.ToChar(Console.ReadLine());

            
            
            if(int.TryParse(value1, out int x))
            {
                Console.WriteLine("çalışır.");
                
            }
            else
            {
                Console.WriteLine("çalışmaz1");
            }
            if (int.TryParse(value2, out int y))
            {
                Console.WriteLine("çalışır.");

            }
            else
            {
                Console.WriteLine("çalışmaz2");
                return;
            }
            int number1 = Convert.ToInt32(value1);
            int number2 = Convert.ToInt32(value2);
            if (number1 > number2 && number1 % 5 == 0 && number2 > 0)
            {
                double result = Calculate(number1, number2, operation);
            }
            else
            {
                if (number1 <= number2)
                {
                    Console.WriteLine("not  because number1 not bigger than number2");
                }
                if (number1 % 5 != 0)
                {
                    Console.WriteLine("not working because number1 not dividing 5");
                }
                if (number2 <= 0)
                {
                    Console.WriteLine("not working because number2 not positive number");
                }
            }


        }
        static double Addition(int num1, int num2)
        {
            return num1 + num2;
        }
        static double Substracting(int num1, int num2)
        {
            return num1 - num2;
        }
        static double Multiplying(int num1, int num2)
        {
            return num1 * num2;
        }
        static double Dividing(int num1, int num2)
        {
            return num1 / num2;
        }
        static double Calculate(int num1, int num2, char operation)
        {
            double result = 0;
            if (operation == '+')
            {
                result = Addition(num1, num2);
            }
            else if (operation == '-')
            {
                result = Substracting(num1, num2);
            }
            else if (operation == '*')
            {
                result = Multiplying(num1, num2);
            }
            else if (operation == '/')
            {
                result = Dividing(num1, num2);
            }
            Console.WriteLine(result);
            return result;
        }
    }
}


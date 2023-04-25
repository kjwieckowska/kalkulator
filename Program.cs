using System;

namespace kalkulator 
{
    internal class Program
    {

        static void Main(string[] args)
        {
            double num1, num2;
            char operation;

            Console.WriteLine("Prosty kalkulator");
            Console.WriteLine("-----------------\n");

            Console.Write("Wprowadź pierwszą liczbę: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Wprowadź drugą liczbę: ");
            num2 = double.Parse(Console.ReadLine());

            Console.Write("Wybierz operację (+,-,*,/): ");
            operation = char.Parse(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
                    break;
                case '-':
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
                    break;
                case '*':
                    Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Nie można dzielić przez zero!");
                    }
                    else
                    {
                        Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
                    }
                    break;
                default:
                    Console.WriteLine("Nieprawidłowa operacja!");
                    break;
            }

            Console.ReadLine();
        }
    }
}
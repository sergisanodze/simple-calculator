using System.Diagnostics.CodeAnalysis;

namespace Advanced_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Choosing the first number
            Console.WriteLine("Enter the first number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            //Choosing the second number
            Console.WriteLine("Enter the Second number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            //Choosing the operation user wants to make
            Console.WriteLine("Choose an arithmetic operation(+,-,*,/)");
            string operation = Console.ReadLine();
            double result;
            switch (operation)
            {
                //if user chooses summary
                case "+":
                    result = num1 + num2;
                    Console.WriteLine(result);
                    break;
                //if user chooses substraction
                case "-":
                    result = num1 - num2;
                    Console.WriteLine(result);
                    break;
                //if user chooses multiplicaton
                case "*":
                    result = num1 * num2;
                    Console.WriteLine(result);
                    break;
                //if user chooses divison
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine(result);
                    }
                //it is not possible to divide number to zero
                    else
                    {
                        Console.WriteLine("Error, it is not possible!");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
                    
            }
                Console.ReadLine();


        }
    }
}

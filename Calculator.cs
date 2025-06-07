namespace Simple_Calculator
{   
    ///<summary>
    /// Simple calculator of two numbers.
    ///</summary>///
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            // choosing a first number.
            Console.WriteLine("Enter a first number!");
            double firstNumber;
            firstNumber = double.Parse(Console.ReadLine());
            // choosing a second number
            Console.WriteLine("Enter a second number!");
            double secondNumber;
            secondNumber = double.Parse(Console.ReadLine());
            // Summary of numbers
            double summary;
            summary = firstNumber + secondNumber;
            summary = Math.Round(summary, 2);
            // Substraction of numbers  
            double sub;
            sub = firstNumber - secondNumber;
            // Multiplication of numbers
            double multiply;
            multiply = firstNumber * secondNumber;
            // Division of numbers
            double division;
            division = firstNumber / secondNumber;
            division = Math.Round(division, 0);     
            // Modulus of numbers
            double remainder;
            remainder = firstNumber % secondNumber;
            //final answer
            Console.WriteLine($"Your summary is: {summary}"
                                    + "\n" +
                              $"Your substraction is: {sub}"
                                    + "\n" +
                              $"Your multiplication is: {multiply}"
                                    + "\n" +
                              $"Your division is: {division}"+$"({remainder})"); 
                                    
            Console.ReadKey();

        }
    }
}

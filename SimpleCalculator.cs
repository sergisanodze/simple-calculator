// See https://aka.ms/new-console-template for more information
Console.BackgroundColor = ConsoleColor.DarkMagenta;
Console.ForegroundColor = ConsoleColor.Cyan;
///<summary>
///ორი წინასწარ აღებული რიცხვის ჯამი და სხვაობა
///</summary>///

// პირველი რიცხვის არჩევა
Console.WriteLine("Enter a first whole number!");
int firstNumber;
firstNumber = int.Parse(Console.ReadLine());
// მეორე რიცხვის არჩევა
Console.WriteLine("Enter a second whole number!");
int secondNumber;
secondNumber = int.Parse(Console.ReadLine());
// მიმატება პირველი და მეორე რიცხვების
int summary;
summary = firstNumber + secondNumber;
//გამოკლება 
int sub;
sub = firstNumber - secondNumber;
// ნამრავლი
int multiply;
multiply = firstNumber * secondNumber;
// გაყოფა
int division;
division = firstNumber / secondNumber;
// ნაშთი
int reminder;
reminder = firstNumber % secondNumber;
//საბოლოო პასუხი
Console.WriteLine($"Your summary is: {summary}" 
                        + "\n" +
                  $"Your substraction is: {sub}" 
                        + "\n" +
                  $"Your multiplication is: {multiply}" 
                        + "\n" +
                  $"Your division is: {division}"
                        + "\n" +
                  $"Your modulus is: {reminder}");  
Console.ReadKey();




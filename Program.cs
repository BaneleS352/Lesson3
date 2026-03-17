using System;

//Exercise 8.1
public class Program
{
    static void Main()
    {
        // TODO:
        // 1. Print a Windows path using a verbatim string
        Console.WriteLine(@"C:\Users\BaneleS\Downloads\C# Bootcamp\Lesson3");
        // 2. Print a sentence that includes double quotes
        Console.WriteLine(@"Good ""Morning""");
        // 3. Print a 2-line message using a newline escape sequence
        Console.WriteLine("Today is a Tudesday\nHappy Tuesday!!");

        //Exercise 8.2
        // TODO:
        // 1. Ask for a command and normalize it
        Console.Write("Type a command (Add / Remove / Quit): ");
        string command = (Console.ReadLine() ?? "").Trim().ToUpperInvariant();

        if (command == "ADD")
        {
            Console.WriteLine("You chose ADD.");
        }
        else if (command == "REMOVE")
        {
            Console.WriteLine("You chose REMOVE.");
        }
        else if (command == "QUIT")
        {
            Console.WriteLine("Goodbye!");
        }
        else
        {
            Console.WriteLine("Unknown command.");
        }

        //8.3
        Console.Write("What is your age: ");
        string input = (Console.ReadLine() ?? "").Trim();

        if (int.TryParse(input, out int age))
        {
            if (age < 18)
            {
                Console.WriteLine("Minor");
            }
            else
            {
                Console.WriteLine("Adult");
            }
        }
        else
        {
            Console.WriteLine("Thats a invalid number.");
        }
    }
}

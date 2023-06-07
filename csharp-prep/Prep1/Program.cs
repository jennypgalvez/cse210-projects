using System;

class Program
{
    static void Main(string[] args)
    {
        // This is prep 1
        //Prompt the user for their first name
        Console.Write("What is your first name? ");
        String FirstName = Console.ReadLine();
        // Prompt for their last name 
        Console.Write("What is your last name? ");
        String LastName = Console.ReadLine();
        // Display the text back
        Console.WriteLine($"Your name is {LastName}, {FirstName} {LastName}.");
    }
}
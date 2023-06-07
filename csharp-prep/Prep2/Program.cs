using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        String gradeFromUser = Console.ReadLine();
        int grade = int.Parse(gradeFromUser);

        String letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}. ");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations you passed!!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }

    }
}
using System;

class Program
{
    static void Main(string[] args)
    {  

        /*Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());*/

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int guess = 0;
        int guessCount = 0;

        while (guess != magicNumber)
        { 
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            guessCount = guessCount + 1;

                
            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");              
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else if (magicNumber == guess)
            {
                Console.WriteLine("You guessed it!");
            }
        }
        Console.WriteLine($"It took you {guessCount} guesses. ");
        Console.Write("Would you like to play again (yes/no)? ");
    }
}


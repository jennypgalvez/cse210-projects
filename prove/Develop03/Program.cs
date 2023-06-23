using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."));
        scriptures.Add(new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."));
        scriptures.Add(new Scripture(new Reference("1 Nephi", 3, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."));

        while (userInput != "quit")
        {
            Console.Clear();
            Console.WriteLine("Choose a scripture to display:");
            Console.WriteLine("1. Proverbs 3:5-6");
            Console.WriteLine("2. John 3:16");
            Console.WriteLine("3. 1 Nephi 3:7");
            Console.WriteLine("Type the corresponding number or 'quit' to finish");

            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                DisplayScripture(scriptures[0]);
            }
            else if (userInput == "2")
            {
                DisplayScripture(scriptures[1]);
            }
            else if (userInput == "3")
            {
                DisplayScripture(scriptures[2]);
            }
            else if (userInput == "quit")
            {
                break;
            }
        }
    }

    static void DisplayScripture(Scripture scripture)
    {
        string userInput = "";
        while (userInput != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            userInput = Console.ReadLine();

            if (userInput != "quit")
            {
                scripture.HideRandomWords();

                if (scripture.IsCompletelyHidden())
                {
                    break;
                }
            }
        }
    }
}

//I add a menu with 3 different scriptures doing the same function
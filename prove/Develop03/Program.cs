using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       string userInput = "";
       ScriptureLibrary scriptureLibrary = scriptureLibrary();
       Scripture scripture;

       while (userInput != "quit")
       {
            scripture = scriptureLibrary.GetRan
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            userInput = Console.ReadLine();
            
            if(userInput != "quit")
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
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program! ");
        
        int userInput = 0;

        List<string> menu = new List<string>
        {
            "Menu Options: ",
            " - 1. Start breathing activity ",
            " - 2. Start reflecting activity ",
            " - 3. Start listening activity  ",
            " - 4. Quit "
        };

        while (userInput != 4)
        {
            Console.Clear();
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            Console.Write("Select a choice from the menu: ");
            userInput = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (userInput)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                case 2:
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.Run();
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;
                case 4:
                    Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye! " );
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option. ");
                    break;
            }

            if (userInput != 4)
            {
                Console.WriteLine("Press any key to continue... ");
                Console.ReadKey();
            }

        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        var lecture = new Lecture("Introduction to C#", "Learn about C#", DateTime.Now, TimeSpan.FromHours(2),
            new Address("123 Main Street", "Cityville", "Stateville", "Countryville"),  "John Doe", 50);
        
        var reception = new Reception("Networking event", "Connect with industry professionals", DateTime.Now, TimeSpan.FromHours(3),
            new Address("456 Lake Street", "Townville", "Stateville", "Countryville"), "rsvp@email.com");

        var outdoorGathering = new OutdoorGathering("Picnic in the park", "Enjoy a day outdoor activities", DateTime.Now, TimeSpan.FromHours(4),
            new Address("789 Oak Street", "villageville", "StateVille", "Countryville"), "Sunny");

        Console.WriteLine("Lecture - Standard Details:");
        Console.WriteLine(lecture.GetStandardDetails());

        Console.WriteLine("\nLecture - Full Details:");
        Console.WriteLine(lecture.GetFullDetails());

        Console.WriteLine("\nLecture - Short Description:");
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine("\nReception - Standard Details:");
        Console.WriteLine(reception.GetStandardDetails());

        Console.WriteLine("\nReception - Full Details:");
        Console.WriteLine(reception.GetFullDetails());

        Console.WriteLine("\nReception - Short Description:");
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine("\nOutdoor Gathering - Standard Details:");
        Console.WriteLine(outdoorGathering.GetStandardDetails());

        Console.WriteLine("\nOutdoor Gathering - Full Details:");
        Console.WriteLine(outdoorGathering.GetFullDetails());

        Console.WriteLine("\nOutdoor Gathering - Short Description:");
        Console.WriteLine(outdoorGathering.GetShortDescription());

        Console.ReadLine();
    }
}
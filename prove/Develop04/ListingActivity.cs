using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    public ListingActivity()
    {
        this.SetActivityName("Listing Activity");
        this.SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine();
        Console.Write("You may begin");

        ShowCountdown(5);
        Console.WriteLine();
        Console.WriteLine();

        int responseCount = CollectResponses();

        Console.WriteLine();
        Console.WriteLine($"You listed {responseCount} responses.");
        Console.WriteLine();

        DisplayEndingMessage();
        return;
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }

    private void ShowCountdown(int duration)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.Write($"\r{i}");
            Thread.Sleep(1000);
        }
    }

    private int CollectResponses()
    {
        HashSet<string> responses = new HashSet<string>();

        string input = Console.ReadLine();
        while (!string.IsNullOrEmpty(input))
        {
            responses.Add(input);
            input = Console.ReadLine();
        }

        return responses.Count;
    }

}

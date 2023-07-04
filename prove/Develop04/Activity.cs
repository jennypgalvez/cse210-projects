using System.Diagnostics;
using System.Threading;
class Activity
{
    private string description;
    private string name;
    static int spinnerCounter;
    static int duration;

    public Activity()
    {
        spinnerCounter = duration = 0;
    }

    public void SetActivityName(string _activityName)
    {
        name = _activityName;
    }

    public void SetDescription(String _description)
    {
        description = _description;
    }

    public int GetDuration()
    {
        return duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {name}. ");
        Console.WriteLine();
        Console.WriteLine(description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get Ready!.... ");
        ShowSpinner(5);

        Console.Clear();

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!! ");
        Console.WriteLine();
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {duration} seconds of the {name}. ");
        Console.WriteLine();
        ShowSpinner(5);
        Console.WriteLine();

    }

    public void ShowSpinner(int numSecondsToRun)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        int left = Console.CursorLeft;
        int top = Console.CursorTop;

        while (stopwatch.ElapsedMilliseconds / 1000 < numSecondsToRun)
        {
            spinnerCounter++;
            switch (spinnerCounter % 4)
            {
                case 0:
                    Console.SetCursorPosition(left, top);
                    Console.WriteLine("/");
                    break;
                case 1:
                    Console.SetCursorPosition(left, top);
                    Console.WriteLine("-");
                    break;
                case 2:
                    Console.SetCursorPosition(left, top);
                    Console.WriteLine("\\");
                    break;
                case 3:
                    Console.SetCursorPosition(left, top);
                    Console.WriteLine("|");
                    break;
            }
            Thread.Sleep(100);
        }



    }

    public void ShowCountDown(int numSecondsToRun)
    {
        for (int i = numSecondsToRun; i >=1; i--)
        {
            Console.Write(string.Format("{0}", i));
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(1000);

        }
        Console.Write(" ");
    }

}
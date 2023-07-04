using System.Diagnostics;

class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> reflectionQuestions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity()
    {
        this.SetActivityName("Reflection Activity");
        this.SetDescription("This activity will help you reflect on a meaningful experience. " +
            "Consider the following prompt and answer a series of questions related to the experience.");
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine();
        Console.WriteLine("Get Ready!...");
        ShowSpinner(5);
        Console.WriteLine();
        string prompt = GetRandomPrompt();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine(prompt);
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to the experience:");
        Console.WriteLine();
        ShowReflectionQuestions(GetDuration());
        Console.WriteLine();
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }

    private void ShowReflectionQuestions(int duration)
    {
        var stopwatch = Stopwatch.StartNew();
        Random random = new Random();

        while (stopwatch.ElapsedMilliseconds / 1000 < duration)
        {
            Console.Clear();

            string question1 = reflectionQuestions[random.Next(reflectionQuestions.Count)];
            string question2 = reflectionQuestions[random.Next(reflectionQuestions.Count)];

            DisplayQuestionWithCountdown(question1, 5);
            DisplayQuestionWithCountdown(question2, 5);
        }
    }

    private void DisplayQuestionWithCountdown(string question, int countdownSeconds)
    {
        Console.WriteLine(question);
        Countdown(countdownSeconds);
        Console.WriteLine();
    }

    private void Countdown(int seconds)
    {
        for (int i = seconds; i >= 0; i--)
        {
            Console.Write($"\r{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}



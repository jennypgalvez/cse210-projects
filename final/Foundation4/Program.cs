using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        DateTime activityDate = new DateTime(2022, 11, 3);
        activities.Add(new Running(activityDate, 30, 3.0));
        activities.Add(new Running(activityDate, 30, 4.8));
        activities.Add(new Cycling(activityDate, 45, 15));
        activities.Add(new Swimming(activityDate, 60, 10));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
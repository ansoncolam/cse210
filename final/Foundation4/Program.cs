using System;

class Program
{
    static void Main(string[] args)
    {

        List<Activity> activityList = new List<Activity>();

        Running activity1 = new Running(new DateOnly(2022, 10, 15), 30, 4.8);
        Cycling activity2 = new Cycling(new DateOnly(2023, 2, 20), 40, 10);
        Swimming activity3 = new Swimming(new DateOnly(2023, 5, 22), 25, 15);

        activityList.Add(activity1);
        activityList.Add(activity2);
        activityList.Add(activity3);

        foreach(Activity activity in activityList) {
            Console.WriteLine($"{activity.GetSummary()}");
        }

    }
}
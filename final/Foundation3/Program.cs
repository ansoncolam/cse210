using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> eventList = new List<Event>();

        Lecture event1 = new Lecture("The Time Clock of Your Body", "Want to know what happen to your body during different hours of a day? Come join the lecuture to get familiar with your own \"body\" language.", new DateOnly(2023, 9, 1), new TimeOnly(10, 0), new Address("CCC Hall, 343 High Lane", "Camp Hill", "CA", "USA"), "Doctor Tom A. Tree", 60);
        Reception event2 = new Reception("Reception for New Students", "ABC College is holding a reception for the new students. Refreshment will be served. Please RSVP.", new DateOnly(2023, 8, 15), new TimeOnly(14, 0), new Address ("SSS Ballroom, ABC street", "Gotham City", "NJ", "USA"), "admin@abccollege.com");
        Outdoor event3 = new Outdoor("Kite Club Gathering", "Annual Kite Club Gathering will be held this coming August. Come bring your favorite kite and \"fly\" with us.", new DateOnly(2023, 8, 19), new TimeOnly(10, 0), new Address("State Park, 222 Cannon Road", "Orange Town", "UT", "USA"), "Sunny & Windy");

        eventList.Add(event1);
        eventList.Add(event2);
        eventList.Add(event3);

        Console.WriteLine("----- Standard Details Display -----");            Console.WriteLine("");
        foreach(Event item in eventList) {
            item.StandardDisplay();
            Console.WriteLine("");
        }

        Console.WriteLine("----- Full Details Display -----");
        Console.WriteLine("");
        foreach(Event item in eventList) {
            item.FullDisplay();
            Console.WriteLine("");
        }

        Console.WriteLine("----- Short Description Display -----");
        Console.WriteLine("");
        foreach(Event item in eventList) {
            item.ShortDisplay();
            Console.WriteLine("");
        }

    }
}
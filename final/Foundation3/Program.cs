public class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "12345");
        Address address2 = new Address("456 State St", "Salt Lake City", "UT", "67890");
        Address address3 = new Address("789 Forest Rd", "Stevensville", "MI", "54321");

        Event event1 = new Lecture("Introduction to Programming", "Learn the basics of programming", new DateTime(2023, 4, 10), "1:00pm", address1, "John Deere", 50);
        Event event2 = new Reception("Company Networking Event", "Meet other professionals and expand your network", new DateTime(2023, 5, 1), "5:00pm", address2, "rsvp@company.com");
        Event event3 = new OutdoorGathering("Summer Picnic", "Enjoy food and games in the park", new DateTime(2023, 6, 17), "12:00pm", address3, "Sunny with a high of 80°F");

        Console.WriteLine("Event 1 - Lecture");
        Console.WriteLine(event1.GetStandardDetails());
        Console.WriteLine(event1.GetFullDetails());
        Console.WriteLine(event1.GetShortDescription());

        Console.WriteLine();

        Console.WriteLine("Event 2 - Reception");
        Console.WriteLine(event2.GetStandardDetails());
        Console.WriteLine(event2.GetFullDetails());
        Console.WriteLine(event2.GetShortDescription());

        Console.WriteLine();

        Console.WriteLine("Event 3 - Outdoor Gathering");
        Console.WriteLine(event3.GetStandardDetails());
        Console.WriteLine(event3.GetFullDetails());
        Console.WriteLine(event3.GetShortDescription());
    }
}

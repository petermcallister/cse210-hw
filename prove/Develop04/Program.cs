using System;
//main
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the meditation program!");
        Console.WriteLine("How many minutes would you like to meditate for?");
        int minutes = int.Parse(Console.ReadLine());

        int milliseconds = minutes * 60 * 1000;
        DateTime end = DateTime.Now + new TimeSpan(0, 0, 0, 0, milliseconds);

        MeditationProgram meditationProgram = new MeditationProgram();

        while (DateTime.Now < end)
        {
            Console.Clear();
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");

            int activity = int.Parse(Console.ReadLine());

            switch (activity)
            {
                case 1:
                    meditationProgram.Breathe();
                    break;
                case 2:
                    Console.WriteLine("Think of a time when you were successful or demonstrated strength.");
                    Console.WriteLine("How are you different because of that expereince?");
                    Console.WriteLine("What can you do to have more of those expereinces?");
                    break;
                case 3:
                    Console.WriteLine("List as many things as you can in a certain area of strength or positivity.");
                    Console.WriteLine("List as many things as you can on what you are not doing, but what you should be doing.");
                    Console.WriteLine("List as many things as you can on what you are doing that you should stop doing.");

                    break;
            }

            meditationProgram.Quote();
            Thread.Sleep(1000);
        }

        Console.WriteLine("Meditation program ended. Press any key to exit...");
        Console.ReadKey();
    }
}

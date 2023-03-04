using System;
using System.Threading;

public abstract class Meditation
{
    public abstract void Breathe();

    public virtual void Quote()
    {
        Console.WriteLine("Relax and clear your mind.");
    }
}

public class MeditationProgram : Meditation
{
    public override void Breathe()
    {
        Console.WriteLine("Breathe in...");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(".");
            Thread.Sleep(200);
        }
        Console.WriteLine();
        Console.WriteLine("Breathe out...");
        for (int i = 10; i >= 1; i--)
        {
            Console.Write(".");
            Thread.Sleep(200);
        }
        Console.WriteLine();
    }

    public override void Quote()
    {
        base.Quote();
        Random rnd = new Random();
        int index = rnd.Next(0, 5);
        string[] quotes = new string[] {
            "The quieter you become, the more you can hear. - Baba Ram Dass",
            "Don't let yesterday take up too much of today. - Will Rogers",
            "In the end, just three things matter: How well we have lived. How well we have loved. How well we have learned to let go. - Jack Kornfield",
            "Breathe in peace, breathe out stress. Relaxing is life.",
            "If you want to conquer the anxiety of life, live in the moment, live in the breath. - Amit Ray",
            "Be where you are; otherwise you will miss your life. - Buddha"
        };
        Console.WriteLine(quotes[index]);
    }
}

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
            meditationProgram.Breathe();
            meditationProgram.Quote();
            Thread.Sleep(1000);
        }

        Console.WriteLine("Meditation program ended. Press any key to exit...");
        Console.ReadKey();
    }
}

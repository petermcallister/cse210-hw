using System;
//
public abstract class Meditation
{
    public abstract void Breathe();

    public virtual void Quote()
    {
        Console.WriteLine("Relax and clear your mind.");
    }
}

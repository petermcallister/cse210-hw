public class ConsoleManager
{
    public void ClearConsole()
    {
        Console.Clear();
    }

    public void Write(string text)
    {
        Console.Write(text);
    }

    public string ReadLine()
    {
        return Console.ReadLine();
    }
}

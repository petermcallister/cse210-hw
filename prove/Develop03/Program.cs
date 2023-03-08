class Program
{
    static void Main(string[] args)
    {
        var scriptureGenerator = new ScriptureGenerator();
        var consoleManager = new ConsoleManager();

        while (true)
        {
            var scripture = scriptureGenerator.GetNextScripture();
            if (scripture == null)
            {
                consoleManager.Write("No more scriptures. Press any key to exit.");
                consoleManager.ReadLine();
                break;
            }

            var fullText = scripture.GetFullText();
            consoleManager.Write(fullText);
            consoleManager.ReadLine();

            while (scripture.HasHiddenWords())
            {
                consoleManager.ClearConsole();
                var hiddenText = scripture.GetHiddenText(3);
                consoleManager.Write(hiddenText);
                consoleManager.ReadLine();
            }
        }
    }
}

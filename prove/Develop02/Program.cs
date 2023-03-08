using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Journal journal = new Journal();
        Entry entry = new Entry();
        string _Choice = "";
        while (_Choice != "5")
        {
            Console.WriteLine("Welcome to the MyJournal Program! Choose and option: ");
            Console.WriteLine("1:Write, 2:Display, 3:Save, 4:Load, 5:Quit ");
            _Choice = Console.ReadLine();

            if(_Choice == "1")
            {
                string _writtenEntry = entry.NewEntry();
                journal._entriesList.Add(_writtenEntry);
            }
            else if(_Choice == "2")
            {
                journal.DisplayEntries();
            }
            else if(_Choice == "3")
            {
                journal.SaveEntries();
            }
            else if(_Choice == "4")
            {
                journal.LoadEntries();
            }
        }

    }
}
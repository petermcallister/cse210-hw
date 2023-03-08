using System.IO;
public class Journal

{
    //public string _employeeName = "Andrew Spinx";
    public List<string> _entriesList = new List<string>();

    public void DisplayEntries()
    {
        //Console.WriteLine($"{_employeeName}: ");
        foreach(string entry in _entriesList)
        {
            Console.WriteLine($"{entry}");
        }
    } 

    public void SaveEntries()
    {
        Console.WriteLine("What is the File name (as a .txt file)? ");
        string _fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
        foreach(string entry in _entriesList)
        {
            outputFile.WriteLine($"{entry}");
        }
        }

    }  

    public void LoadEntries()
    {
        Console.WriteLine("What is the File name? ");
        string _fileName = Console.ReadLine(); 
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string _loadEntry = parts[0];
            _entriesList.Add(_loadEntry);
        } 
    }
}
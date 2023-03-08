public class Entry
{
  public List<string> _promptsList = new List<string>()
    {"Favorite class?", "Favorite programming language?", "What did you have for breakfast?", "What is your favorite part of your major?", "Favortie thing learned in class?"};
    
    public string NewEntry()
    {
    Random _promptNumber = new Random();
    DateTime _currentDate = DateTime.Now;
    string _entryDate = _currentDate.ToShortDateString();
    int _promptChoice = _promptNumber.Next(0,5);
    string _newPrompt = _promptsList.ElementAt(_promptChoice);
    Console.WriteLine($"{_newPrompt} ");
    string _userResponse = Console.ReadLine();
    string _finishedEntry = $"{_entryDate}- Prompt:{_newPrompt} - {_userResponse}";
    return _finishedEntry;
    }
}
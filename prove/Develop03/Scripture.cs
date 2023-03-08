public class Scripture
{
    public string Reference { get; set; }
    public string Text { get; set; }

    public Scripture(string reference, string text)
    {
        Reference = reference;
        Text = text;
    }

    public string GetFullText()
    {
        return $"{Reference}: {Text}";
    }

    public string GetHiddenText(int numWordsToHide)
    {
        var words = Text.Split(' ');
        var random = new Random();
        var indexes = Enumerable.Range(0, words.Length).OrderBy(x => random.Next()).Take(numWordsToHide).ToList();
        for (int i = 0; i < indexes.Count; i++)
        {
            words[indexes[i]] = new string('_', words[indexes[i]].Length);
        }
        return $"{Reference}: {string.Join(" ", words)}";
    }

    public bool HasHiddenWords()
    {
        return Text.Contains("_");
    }
}

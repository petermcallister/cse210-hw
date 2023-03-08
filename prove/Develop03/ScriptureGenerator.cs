public class ScriptureGenerator
{
    private List<Scripture> scriptures;
    private int currentScriptureIndex;

    public ScriptureGenerator()
    {
        scriptures = new List<Scripture>();
        currentScriptureIndex = 0;
        InitializeScriptures();
    }

    private void InitializeScriptures()
    {
        scriptures.Add(new Scripture("John 3:16", "For God so loved the world, that he dgave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."));
        scriptures.Add(new Scripture("Proverbs 3:5-6", "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."));
        scriptures.Add(new Scripture("Philippians 4:6-7", "Be careful for nothing; but in every thing by prayer and supplication with thanksgiving let your requests be made known unto God. And the peace of God, which passeth all understanding, shall keep your hearts and minds through Christ Jesus."));
    }

    public Scripture GetNextScripture()
    {
        if (currentScriptureIndex >= scriptures.Count)
        {
            return null;
        }
        var scripture = scriptures[currentScriptureIndex];
        currentScriptureIndex++;
        return scripture;
    }
}

class Scripture
{
    Reference reference;
    List<Word> words;
    private Random random;

    public Scripture(Reference _reference, string _text)
    {
        reference = _reference;
        words = new List<Word>();
        random = new Random();

        List<string> allWords = _text.Split(" ").ToList();
        
        foreach(string wordString in allWords)
        {
            Word newWord = new Word(wordString);
            words.Add(newWord);
        }

    }

    public void HideRandomWords()
    {
        List<Word> visibleWords = words.FindAll(word => !word.GetIsHidden());

        if (visibleWords.Count > 0)
        {
            int randomIndex = random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
        } 
    }

    public string GetDisplayText()
    {
        string scriptureText = "";

        foreach (Word word in words)
        {
            if(word.GetIsHidden() == false)
            {
                scriptureText += word.GetDisplayText() + " ";
            }
            else
            {
                scriptureText += new string('_', word.GetDisplayText().Length) + " ";
            }
        }
        return $"{reference.GetDisplayText()} {scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        return words.TrueForAll(word => word.GetIsHidden());
    }

}
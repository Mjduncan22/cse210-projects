class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public string Scriptures(Reference reference, string text)
    {
        _reference = reference;
        string[] wordText = text.Split(" ");
        foreach (string word in wordText)
        {
            _words.Add(new Word(word));
        }
        string scripture = $"{_reference.GetDisplayText()} {text}";
        return scripture;
    }


    public void HideRandomWords(int numberToHide)
    {
        int length = _words.Count;
        int hiddenCount = 0;
        while (numberToHide != hiddenCount && IsCompletelyHidden() == false)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, length);
            // Logic added to exclude hidden words from being selected
            if (_words[randomNumber].IsHidden() == false)    
                {
                    _words[randomNumber].Hide();
                    hiddenCount = hiddenCount + 1;
                }
        }
    }
    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        List<string> wordText = new List<string>();
        foreach (Word word in _words)
        {
            wordText.Add(word.GetDisplayText().ToString());
        }
        string scriptureText = $"{referenceText} {string.Join(" ",wordText)}";

        return scriptureText;
    }
    public bool IsCompletelyHidden()
    {
        bool finished = true;
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                finished = false;
            }
        }
        return finished;
    }
}


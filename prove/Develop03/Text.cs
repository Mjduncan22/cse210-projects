public class Text
{
    private List<(string referenceBook, int referenceChapter, int verse, int? endVerse, string textString)> _reference = new List<(string referenceBook, int referenceChapter, int verse, int? endVerse, string textString)>
        {
            ("John", 3, 16, null, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            ("John", 16, 33, 34, "These things I have spoken unto you, that in me ye might have peace. In the world ye shall have tribulation: but be of good cheer; I have overcome the world.")
        };
    private string _text = "";

    public void MakeScriptureList()
    {
        int index = 0;
        foreach (var scripture in _reference)
            {
                index = index + 1;
                string indexString = index.ToString();
                if (scripture.endVerse.HasValue)
                    {
                        Console.WriteLine($"{indexString}. {scripture.referenceBook} {scripture.referenceChapter}:{scripture.verse}-{scripture.endVerse.Value}");
                    }
                else
                {
                    Console.WriteLine($"{indexString}. {scripture.referenceBook} {scripture.referenceChapter}:{scripture.verse}");;
                }
            };
    }

    public (string referenceBook, int referenceChapter, int verse, int? endVerse) SelectScripture(int number)
    {
        int index = 0;
        foreach (var scripture in _reference)
            {
                index = index + 1;
                if (number == index)
                {
                    _text = scripture.textString;
                    if (scripture.endVerse.HasValue)
                    {
                        return(scripture.referenceBook, scripture.referenceChapter, scripture.verse, scripture.endVerse.Value);
                    }
                    else
                    {
                        return(scripture.referenceBook, scripture.referenceChapter, scripture.verse,null);
                    }
                }
            }
        throw new ArgumentOutOfRangeException(nameof(number), "Please try again with a valid number");
    }
    public string GetScriptureText()
    {
        return _text;
    }
}
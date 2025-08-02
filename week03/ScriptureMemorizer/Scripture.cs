/*
Attributes:
_reference: Reference
_words: List<Word>

Constructors:
Scripture(Rerefence: Reference, text: string)

Behaviors:
HideRandomWords(numberToHide: int): void
GetDisplayText(): string
IsCompletelyHidden(): bool
*/

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture()
    {
    }
    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;

        text = string.Join(" ", _words);
    }

    public void HideRandomWords()
    {
        var randomWord = new Random();
        int index = randomWord.Next(_words.Count);
        Word word = _words[index];
        word.Hide();
       
    }
    public string GetDisplayText()
    {
        return $"{_reference} - {_words}";
    }
    public bool IsCompletelyHidden()
    { 
        return true;
    }
}
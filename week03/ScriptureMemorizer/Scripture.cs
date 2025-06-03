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

    }

    public void HideRandomWords()
    {

    }
    public string GetDisplayText()
    {
        return "";
    }
    public bool IsCompletelyHidden()
    {
        return true;
    }
}
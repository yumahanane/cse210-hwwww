/*
Attributes:
_text: string
_isHidden: bool

Constructors:
Word(text: string)

Behaviors:
Hide(): void
Show(): void
IsHidden(): bool
GetDisplayText(): string
*/

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word()
    {
    }
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // methods
    public void Hide()
    {
        int size = _text.Length;
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("_");
        }
    }
    public void Show()
    {
        int size = _text.Length;
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(i);
        }
    }
    public void IsHidden()
    {
        if (_text == "_")
        {
            Console.WriteLine(_isHidden);
        }

    }
    public string GetDisplayText()
    {
        return _text;
    }
}
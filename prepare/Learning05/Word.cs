// Word.cs
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

    public string GetText()
    {
        return _isHidden ? "_____" : _text;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public Reference Reference { get; private set; }
    private List<Word> Words { get; set; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int count)
    {
        var visibleWords = Words.Where(w => !w.IsHidden).ToList();
        var wordsToHide = visibleWords.OrderBy(_ => Guid.NewGuid()).Take(count);

        foreach (var word in wordsToHide)
        {
            word.Hide();
        }
    }

    public bool AllWordsHidden()
    {
        return Words.All(w => w.IsHidden);
    }

    public override string ToString()
    {
        return $"{Reference}\n{string.Join(' ', Words)}";
    }
}
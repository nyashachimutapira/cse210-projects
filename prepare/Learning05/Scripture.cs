using System;
using System.Collections.Generic;

namespace JournalApp.Models // Use an appropriate namespace
{
    // Represents a scripture with a reference and a list of words
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words;
        private Random _random = new Random();

        public Scripture(string reference, string text)
        {
            _reference = new Reference(reference);
            _words = new List<Word>();
            foreach (var word in text.Split(' '))
            {
                _words.Add(new Word(word));
            }
        }

        public string GetFullText()
        {
            return $"{_reference.GetReference()} {string.Join(" ", _words.ConvertAll(w => w.GetText()))}";
        }

        public void HideRandomWord()
        {
            if (IsAllWordsHidden()) return;

            int index;
            do
            {
                index = _random.Next(_words.Count);
            } while (_words[index].IsHidden());

            _words[index].Hide();
        }

        public bool IsAllWordsHidden()
        {
            foreach (var word in _words)
            {
                if (!word.IsHidden())
                    return false;
            }
            return true;
        }
    }

    // Represents a reference to the scripture
    public class Reference
    {
        private string _reference;

        public Reference(string reference)
        {
            _reference = reference;
        }

        public string GetReference()
        {
            return _reference;
        }
    }

    // Represents a single word in the scripture
    public class Word
    {
        private string _text;
        private bool _isHidden;

        public Word(string word)
        {
            _text = word;
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
}
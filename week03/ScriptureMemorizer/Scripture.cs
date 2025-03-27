using System.Collections.Generic;
using System.Linq;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();


    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int attempts = 0;
        int hidden = 0;

        while (hidden < numberToHide && attempts < 100)
        {
            int randomIndex = random.Next(_words.Count);
            if (!_words[randomIndex].IsHidden())
            {
                _words[randomIndex].Hide();
                hidden++;
            }
            attempts++;

        }

    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " - ";

        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }

        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }



}
using System.Collections.Generic;
using System.Linq;
public class Scripture
{
    private Reference _reference;
    private List<string> _words;


    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').ToList();
    }

    public void HideRandomWords(int numbwerToHide)
    {
        Random random = new Random();

        int hidden = 0;

        while (hidden < 3)
        {
            int randomIndex = random.Next(_words.Count);
            if (_words[randomIndex] != "_")
            {
                _words[randomIndex] = "_";
                hidden++;
            }

        }

    }

    public string GetDisplayText()
    {
        return string.Join(" ", _words);
    }

    public bool IsCompletelyHidden()
    {
        foreach (string word in _words)
        {
            if (word != "_")
            {
                return false;
            }
        }
        return true;
    }



}
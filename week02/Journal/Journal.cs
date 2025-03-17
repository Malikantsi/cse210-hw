using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        // provide user input and store it in newEntry
        // call  Entry() constructor
       
        Console.WriteLine();
        _entries.Add(newEntry);

    }

    public void DisplayAll()
    {
        foreach (Entry item in _entries)
        {
            item.Display();
        }

    }

    public void SaveToFile(string file)
    {
        Console.WriteLine($"{_entries[0]._date}");
        using (StreamWriter saveFile = new StreamWriter(file))
        {
            foreach (Entry item in _entries)
            {
                // saveFile.WriteLine($"{item},");
                saveFile.WriteLine($"{item._date},{item._promptText},{item._entryText}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        string[] lines = File.ReadAllLines(file);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');

            if (parts.Length == 3)
            {
                Entry newEntry = new Entry
                {
                    _date = parts[0],
                    _promptText = parts[1],
                    _entryText = parts[2]
                };
                _entries.Add(newEntry);
            }
            //  Console.WriteLine($"\t{parts[0]}\t{parts[1]}\n{parts[2]}");
        }

    }
}
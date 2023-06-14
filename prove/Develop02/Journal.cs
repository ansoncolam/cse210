public class Journal {
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry) {
        _entries.Add(newEntry);
    }

    public void DisplayAll() {
        foreach (Entry entry in _entries) {
            entry.Display();
        }
    }

    public void SaveToFile(string fileName) {
        using (StreamWriter outputFile = new StreamWriter(fileName)) {
            foreach (Entry entry in _entries) {
                outputFile.WriteLine($"{entry._date}~|~{entry._promptText}~|~{entry._entryText}");
            }
        }

    }

    public void LoadFromFile(string fileName) {
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines) {
            string[] parts = line.Split("~|~");
            Entry loadEntry = new Entry();
            loadEntry._date = parts[0];
            loadEntry._promptText = parts[1];
            loadEntry._entryText = parts[2];
            _entries.Add(loadEntry);
            
        }
    
    }
}
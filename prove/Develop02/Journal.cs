using System.IO;
class Journal {
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(){
        Entry entry = new Entry();
        PromptGenerator PromptGenerator = new PromptGenerator();
        entry._prompt = PromptGenerator.GetRandomPrompt();
        Console.WriteLine($"{entry._prompt} ");
        Console.Write("> ");
        entry._answer = Console.ReadLine();
        DateTime currentDate = DateTime.Now;
        entry._date = currentDate.ToString("M/d/yyyy");
        _entries.Add(entry);
    }

    public void DisplayEntries(){
        foreach (Entry entry in _entries){
            entry.DisplayEntry();
        }
    }

    public void Save(){
        string fileName = "entries.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName)){
            foreach (Entry entry in _entries){
                outputFile.WriteLine($"{entry._answer}, {entry._prompt}, {entry._date}");
            }
        }
    }

    public void Load(){
        string fileName = "entries.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines){
            Entry entry = new Entry();
            string[] parts = line.Split(",");
            entry._answer = parts[0];
            entry._prompt = parts[1];
            entry._date = parts[2];
        }
    }
}
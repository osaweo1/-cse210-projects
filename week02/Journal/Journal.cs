using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.IO;

namespace JournalApp;
public class Journal
{
    private List<Entry>_entries=new List<Entry>();
    public void addEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void displayAll()
    {
        foreach(Entry entry in _entries)
        {
            
            entry.Display();
        }
    }
    public void Savetofile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"Date{entry._date}|{entry._prompt}|{entry._response}")
            }
        }
       
    }
     public void LoadFromFile(string filename)
    {

        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._response = parts[2];

            _entries.Add(entry);
        }
    }
}
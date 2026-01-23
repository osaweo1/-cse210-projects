using System;
namespace JournalApp;
public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public void Display()
    {
        Console.WriteLine($"Date:{_date}");
        Console.WriteLine($"prompt: {_prompt}");
        Console.WriteLine($"response:{_response}");

    }
}
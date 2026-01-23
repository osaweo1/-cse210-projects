using System;
using JournalApp;


class Program
{
    static void Main(string[] args)
    {
         Journal journal = new Journal();
        PromptCreator promptGenerator = new PromptCreator();
        bool active = true;

        while (active)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._prompt = prompt;
                entry._response = response;

                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename: ");
                journal.SaveToFile(Console.ReadLine());
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename: ");
                journal.LoadFromFile(Console.ReadLine());
            }
            else if (choice == "5")
            {
                active = false;
            }
        }
    }
}
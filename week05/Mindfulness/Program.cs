using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
         while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness App");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice: ");

            string choice = Console.ReadLine();

            Activity activity = null;

            if (choice == "1")
            {
                activity=new BreathingActivity();
                
            }
            else if (choice == "2"){
                activity =new ReflectionActivity();
                
            }
            else if (choice == "3")
            {
                activity=new ListingActivity();
                
            }
            else if (choice == "4")
            {
                return;
            }
            

            activity?.Run();
        }
    }
}
    





abstract class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name=name;
        _description=description;
    }


    protected void ShowSpinner(int seconds)
    {
        for(int i = 0; i < seconds; i++)
        {
            Console.WriteLine("...");
            Thread.Sleep(2000);
        }
    }

    public void ShowSleeper(int seconds)
    {
        for (int i = seconds; i >0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(2000);
            Console.Write("\b");
        }
    }
    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"welcome to {_name}.");
        Console.WriteLine(_description);
        Console.WriteLine("please enter duration is seconds:>");
        _duration=int.Parse(Console.ReadLine());

        Console.WriteLine("Geting ready...");
        ShowSleeper(3);

    }

    public void EndActivity()
    {
        Console.WriteLine("congratulations, you have done well!!!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed the {_name} for a {_duration } seconds");
    }
    public abstract void Run();
}


class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity",
        "This activity will help you relax by guiding your breathing.") { }

    public override void Run()
    {
        StartActivity();

        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.Write("\nBreathe in... ");
            ShowSleeper(4);
            Console.Write("\nBreathe out... ");
            ShowSleeper(4);
            elapsed += 2;
        }

        EndActivity();
    }
}

class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you did something difficult.",
        "Think of a time you helped someone.",
        "Think of a time you showed strength."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this meaningful?",
        "What did you learn?",
        "How did you feel?",
        "What made this different?"
         };

    public ReflectionActivity()
        : base("Reflection Activity",
        "This activity helps you reflect on moments of strength.") { }

    public override void Run()
    {
        StartActivity();

        Random rand = new Random();
        Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Count)]);
        ShowSpinner(3);

        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.WriteLine("\n" + _questions[rand.Next(_questions.Count)]);
            ShowSpinner(4);
            elapsed += 4;
        }

        EndActivity();
    }
}

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people you appreciate?",
        "What are your personal strengths?",
        "Who have you helped this week?"
    };

    public ListingActivity()
        : base("Listing Activity",
        "List as many positive things as you can.") { }

    public override void Run()
    {
        StartActivity();

        Random rand = new Random();
        Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Count)]);
        ShowSleeper(5);

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");

        EndActivity();
    }
   
}
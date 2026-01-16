using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("a program to claculate grade of a student");
        // getting grade and calculating to bring Letter relating to grade
        Console.WriteLine("Enter your Percentage grade (0-100): ");
        string input=Console.ReadLine();

        int grade;
        if(!int.TryParse(input, out grade)||grade<0 ||grade>100)
        {
            Console.WriteLine("You entered an invalid input, please enter a number from 0-100");
        };
        string letter = "";
        if(grade>=90)
        {
            letter="A";
        }
        else if(grade>=80)
        {
            letter="B";
        }
        else if(grade>=70)
        {
            letter="C";
        }
        else if (grade >= 60)
        {
            letter="D";
        }
        else
        {
            letter="F";
        }
        // to show if a grade passed

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! you passed");
        }
        else
        {
            Console.WriteLine("Don't worry, keep trying and you'll do better next time.");
        }

        // to determine the sign that will accompany the letter of a grade - or +
        string sign="";
        if(letter != "A" && letter != "F")
        
        {
            int lastNumber = grade % 10;
            if (lastNumber >7)
            {
                sign="+";
            }
            else if(lastNumber < 3)
            {
                sign="-";
            }
        }
        else if (letter == "A")
        {
            int lastNumber= grade % 10;
            if (lastNumber < 3)
            {
                sign="-";
            }

        }
        Console.WriteLine($"Your grade: {letter}{sign}");
    }
}
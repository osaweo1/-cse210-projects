using System;

class Program
{
    static void Main(string[] args)
    // programe to collate numbers, get sum, get averages.
    {
        List<int> numbers = new List<int>();
        int number = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        // Compute sum
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }

        // Compute average
        double average = (double)sum / numbers.Count;

        // Find largest number
        int largest = numbers[0];
        foreach (int n in numbers)
        {
            if (n > largest)
            {
                largest = n;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    
    }
}
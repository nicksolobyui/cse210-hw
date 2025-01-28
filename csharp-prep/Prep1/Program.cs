using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        string namefirst = Console.ReadLine();

        Console.WriteLine("What is your last name?");
        string namelast = Console.ReadLine();

        Console.WriteLine($"Your name is {namelast}, {namefirst} {namelast}.");

    }
}
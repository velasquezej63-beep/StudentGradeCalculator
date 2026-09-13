using System;

class Program
{
    static void Main()
    {
        string name;
        double grade1, grade2, grade3;
        double average;

        Console.Write("Enter student name: ");
        name = Console.ReadLine();

        Console.Write("Enter Grade 1: ");
        grade1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Grade 2: ");
        grade2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Grade 3: ");
        grade3 = Convert.ToDouble(Console.ReadLine());

        average = (grade1 + grade2 + grade3) / 3;

        Console.WriteLine();
        Console.WriteLine("===== STUDENT RESULT =====");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Average: " + average.ToString("F2"));

        if (average >= 75)
        {
            Console.WriteLine("Status: PASSED");
        }
        else
        {
            Console.WriteLine("Status: FAILED");
        }
    }
}


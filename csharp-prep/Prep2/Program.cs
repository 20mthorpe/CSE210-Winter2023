using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradeInput = Console.ReadLine();
        int grade = int.Parse(gradeInput);

        string letterGrade = "Not available";
        bool pass = false;

        if (grade >= 90)
        {
            letterGrade = "A";
            pass = true;
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
            pass = true;
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
            pass = true;
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"You got a(n) {letterGrade} in the classs.");

        if (pass == true)
        {
            Console.WriteLine("You passed the class. Great job!");
        }
        else
        {
            Console.WriteLine("You did not pass the class. Try again, maybe you will next time.");
        }
    }
}
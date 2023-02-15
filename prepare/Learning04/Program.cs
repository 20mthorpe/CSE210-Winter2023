using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine();
        Assignment assign1 = new Assignment("Mary Thorpe", "Muliplication tables");
        Console.WriteLine(assign1.GetSummary());

        MathAssignment math1 = new MathAssignment("John Doe", "Long Division", "5.2", "12-30");
        System.Console.WriteLine(math1.GetSummary());
        System.Console.WriteLine(math1.GetHomeworkList());

        WritingAssignment write1 = new WritingAssignment("Grace Pettit", "Family Relations", "Conflict Resolution");
        System.Console.WriteLine(write1.GetSummary());
        System.Console.WriteLine(write1.GetWritingInformation());

        System.Console.WriteLine();
    }
}
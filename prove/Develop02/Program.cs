using System;

class Program
{
    static void Main(string[] args)
    {

        string choice = "nothing for now";

        do
        {
            Journal journal1 = new Journal();
            choice = GetChoice();

            if (choice == "1")
            {
                journal1.AddEntry();
            }
            else if (choice == "2")
            {
                journal1.Display();
            }
            else if (choice == "3")
            {
                journal1.LoadFromFile();
                Console.WriteLine("Journal has been loaded from file");
            }
            else if (choice == "4")
            {
                journal1.SaveToFile();
                Console.WriteLine("Journal has been saved");
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye");
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }

        }while (choice != "5");

    }

    static string GetChoice(){
        Console.WriteLine("Please select one of the following choices. ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What is your choice? ");
        string choice = Console.ReadLine();
        return choice;
    }

}

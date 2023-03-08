using System;

class Program
{
    static void Main(string[] args)
    {

        string option = "-1";

        while (option != "6")
        {

            System.Console.WriteLine("Menu Options:");
            System.Console.WriteLine("1. Create New Goal");
            System.Console.WriteLine("2. List Goals");
            System.Console.WriteLine("3. Save Goals");
            System.Console.WriteLine("4. Load Goals");
            System.Console.WriteLine("5. Record Event");
            System.Console.WriteLine("6. Quit");

            option = System.Console.ReadLine();

            if (option == "1")
            {
                System.Console.WriteLine("Select option from the Menu:");
                System.Console.WriteLine("1. Simple Goal");
                System.Console.WriteLine("2. Eternal Goal");
                System.Console.WriteLine("3. Checklist Goal");

                string goalType = System.Console.ReadLine();

                if (goalType == "1")
                {
                    System.Console.WriteLine("Create a simple goal here");
                }
                else if (goalType == "2")
                {
                    System.Console.WriteLine("Create an eternal goal here");
                }
                else if (goalType == "3")
                {
                    System.Console.WriteLine("Create a checklist goal here");
                }
                else
                {
                    System.Console.WriteLine("Invalid Entry, next time please type a number between 1 and 3.");
                }
            }

            else if (option == "6")
            {
                System.Console.WriteLine("Goodbye:)");
            }
            else
            {
                System.Console.WriteLine("Invalid entry, please type a number between 1 and 6");
            }
        }
    }
}
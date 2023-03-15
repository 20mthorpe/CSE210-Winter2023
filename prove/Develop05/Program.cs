using System;

class Program
{
    static void Main(string[] args)
    {

        List<Goal> goals = new List<Goal>();

        //int getTotalPoints()
        //{
        //    int totalPoints = 0;
        //    foreach (Goal g in goals)
        //    {
        //        if (g.GetComplete())
        //        {
        //            totalPoints += g.GetPoints();
        //        }
        //    }
        //    return totalPoints;
        //}
        int totalPoints = 0;

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
                    System.Console.Write("What is the name of your goal? ");
                    string name = System.Console.ReadLine();
                    System.Console.Write("What is a short description of it? ");
                    string desc = System.Console.ReadLine();
                    System.Console.Write("What is the amount of points associated with this goal? ");
                    string inputPoints = System.Console.ReadLine();
                    int points = Int32.Parse(inputPoints);

                    SimpleGoal sg = new SimpleGoal(points, name, desc, false);
                    goals.Add(sg);

                }
                else if (goalType == "2")
                {
                    System.Console.Write("What is the name of your goal? ");
                    string name = System.Console.ReadLine();
                    System.Console.Write("What is a short description of it? ");
                    string desc = System.Console.ReadLine();
                    System.Console.Write("What is the amount of points associated with this goal? ");
                    string inputPoints = System.Console.ReadLine();
                    int points = Int32.Parse(inputPoints);

                    EternalGoal eg = new EternalGoal(points, name, desc, false);
                    goals.Add(eg);
                }
                else if (goalType == "3")
                {
                    System.Console.Write("What is the name of your goal? ");
                    string name = System.Console.ReadLine();
                    System.Console.Write("What is a short description of it? ");
                    string desc = System.Console.ReadLine();
                    System.Console.WriteLine("What is the amount of points associated with this goal? ");
                    string inputPoints = System.Console.ReadLine();
                    int points = Int32.Parse(inputPoints);
                    System.Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    string inputTimesToCompletion = System.Console.ReadLine();
                    int timesToCompletion = Int32.Parse(inputTimesToCompletion);
                    System.Console.Write("What is the bonus for accomplishing it that many times? ");
                    string inputBonusPoints = System.Console.ReadLine();
                    int bonusPoints = Int32.Parse(inputBonusPoints);

                    ChecklistGoal cg = new ChecklistGoal(points, name, desc, false, timesToCompletion, bonusPoints);
                    goals.Add(cg);
                }
                else
                {
                    System.Console.WriteLine("Invalid Entry, next time please type a number between 1 and 3.");
                }
            }
            else if (option == "2")
            {
                int listNum = 1;
                System.Console.WriteLine("The goals are:");
                foreach (Goal g in goals)
                {
                    string checkmark = " ";
                    if (g.GetComplete())
                    {
                        checkmark = "X";
                    }

                    System.Console.Write($"{listNum}. [{checkmark}] ");
                    g.DisplayGoal();
                    listNum ++;
                }
            }
            else if (option == "3")
            {
                System.Console.WriteLine("Save Goals");
            }
            else if (option == "4")
            {
                System.Console.WriteLine("Load Goals");
            }
            else if (option == "5")
            {
                int listNum = 1;
                System.Console.WriteLine("Select a Goal from the list:");
                foreach (Goal g in goals)
                {
                    System.Console.WriteLine($"{listNum}. {g.GetName()}");
                    listNum ++;
                }
                System.Console.Write("Which goal did you accomplish? ");
                string inputGoal = System.Console.ReadLine();
                int completedGoal = Int32.Parse(inputGoal);
                completedGoal -= 1;

                Type goalType = goals[completedGoal].GetType();
                if (goalType.Equals(typeof(ChecklistGoal)))
                {
                    goals[completedGoal].CompleteEventOnce();
                    if goals[completedGoal]._timesCompleted == goals[completedGoal]._numToCompletion
                    {
                        totalPoints += goals[completedGoal]._bonusPoints;
                        goals[completedGoal].CompleteEvent();
                    }
                    else
                    {
                        totalPoints += goals[completedGoal].GetPoints();
                    }

                }
                else if (goalType.Equals(typeof(SimpleGoal)))
                {
                    goals[completedGoal].CompleteEvent();
                    totalPoints += goals[completedGoal].GetPoints();
                }
                else if (goalType.Equals(typeof(EternalGoal)))
                {
                    totalPoints += goals[completedGoal].GetPoints();
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
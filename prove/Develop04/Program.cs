using System;

class Program
{
    static void Main(string[] args)
    {

        string GetMenuOption()
        {
            System.Console.WriteLine("Menu Options: ");
            System.Console.WriteLine("1. Breathing Activity");
            System.Console.WriteLine("2. Listening Activity");
            System.Console.WriteLine("3. Reflection Activity");
            System.Console.WriteLine("4. Quit");
            System.Console.WriteLine("Select a choice from the menu: ");
            string option = System.Console.ReadLine();
            return option;
        }

        string option = "null";

        while (option != "4"){

            option = GetMenuOption();

            if (option == "1"){
                BreathingActivity breathe = new BreathingActivity(30);
                
                breathe.DisplayStart();
                System.Console.WriteLine();

                breathe.DisplayDiscription();
                System.Console.WriteLine();

                breathe.SetDuration();

                breathe.BeginningPause();

                breathe.DisplayCountdown();

                System.Console.WriteLine();
                breathe.DisplayEnd();
                System.Console.WriteLine();
            }

            else if (option == "2"){
                ListeningActivity listen = new ListeningActivity(30);
                
                listen.DisplayStart();
                System.Console.WriteLine();

                listen.DisplayDiscription();
                System.Console.WriteLine();

                listen.SetDuration();
                // add in specific functionality for this activity

                listen.DisplayEnd();
                System.Console.WriteLine();
            }

            else if (option == "3"){
                ReflectingActivity reflect = new ReflectingActivity(30);
                
                reflect.DisplayStart();
                System.Console.WriteLine();

                reflect.DisplayDiscription();
                System.Console.WriteLine();

                reflect.SetDuration();
                // add in specific functionality for this activity

                reflect.DisplayEnd();
                System.Console.WriteLine();
            }
            
            else if (option == "4")
            {
                System.Console.WriteLine("The end:)");
            }

            else 
            {
                System.Console.WriteLine("That was an invalid input. Please type 1, 2, 3, or 4 next time.");
            }

        }


    }
}
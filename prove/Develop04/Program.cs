using System;

class Program
{
    static void Main(string[] args)
    {

        static string GetMenuOption()
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
                breathe.SetDuration();
                breathe.DisplayDiscription();
                // display countdown does not yet work
                breathe.DisplayCountdown();
                breathe.DisplayEnd();
            }

            else if (option == "2"){
                ListeningActivity listen = new ListeningActivity(30);
                listen.SetDuration();
                listen.DisplayStart();
                listen.SetDuration();
                listen.DisplayDiscription();
                // add in specific functionality for this activity

                listen.DisplayEnd();
            }

            else if (option == "3"){
                ReflectingActivity reflect = new ReflectingActivity(30);
                reflect.SetDuration();
                reflect.DisplayStart();
                reflect.SetDuration();
                reflect.DisplayDiscription();
                // add in specific functionality for this activity

                reflect.DisplayEnd();
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
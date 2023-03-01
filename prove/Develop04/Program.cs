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

                // this is the breathe specific task
                breathe.DisplayCountdown();

                System.Console.WriteLine();
                breathe.DisplayEnd();
                breathe.DisplayDelay(3);
                System.Console.WriteLine();
            }

            else if (option == "2"){
                ListeningActivity listen = new ListeningActivity(30);
                
                listen.DisplayStart();
                System.Console.WriteLine();

                listen.DisplayDiscription();
                System.Console.WriteLine();

                listen.SetDuration();

                listen.BeginningPause();

                // This is the listen specific task
                listen.SetRandomPrompt();
                listen.DisplayRandomPrompt();
                listen.GetItems();
                listen.DisplayItemAmount();

                System.Console.WriteLine();
                listen.DisplayEnd();
                listen.DisplayDelay(3);
                System.Console.WriteLine();
            }

            else if (option == "3"){
                ReflectingActivity reflect = new ReflectingActivity(30);
                
                reflect.DisplayStart();
                System.Console.WriteLine();

                reflect.DisplayDiscription();
                System.Console.WriteLine();

                reflect.SetDuration();

                // this is the reflection specific task
                System.Console.WriteLine();
                System.Console.WriteLine("Consider the following prompt:");
                reflect.SetRandomPrompt();
                reflect.DisplayPrompt();
                System.Console.WriteLine("When you have something in mind, press enter to continue.");
                System.Console.ReadLine();
                reflect.BeginningPause();
                reflect.SetPromptQuestion();
                reflect.DisplayPromptQuestion();
                reflect.DisplayDelay(reflect.GetDuration());

                System.Console.WriteLine();
                reflect.DisplayEnd();
                reflect.DisplayDelay(3);
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
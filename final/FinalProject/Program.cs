using System;

class Program
{
    static void Main(string[] args)
    {
        // Create the four houses
        // Gryffindor
        List<string> gryf_values = new List<string>();
        gryf_values.Add("Bravery");
        gryf_values.Add("Chivalry");

        List<string> gryf_colors = new List<string>();
        gryf_colors.Add("Scarlet");
        gryf_colors.Add("Gold");

        House gryffindor = new House("Gryffindor", "Lion", "Portrait of a Fat Lady in a Pink Dress", gryf_values, gryf_colors, "Nearly Headless Nick", "Godric Gryffindor");

        // Ravenclaw
        List<string> raven_values = new List<string>();
        raven_values.Add("Wit");
        gryf_values.Add("Learning");

        List<string> raven_colors = new List<string>();
        raven_colors.Add("Blue");
        raven_colors.Add("Bronze");

        House ravenclaw = new House("Ravenclaw", "Eagle", "Door of Riddles", raven_values, raven_colors, "The Grey Lady", "Rowena Ravenclaw");

        // Hufflepuff
        List<string> huff_values = new List<string>();
        huff_values.Add("Loyalty");
        huff_values.Add("Hard-Working");

        List<string> huff_colors = new List<string>();
        huff_colors.Add("Yellow");
        huff_colors.Add("Black");

        House hufflepuff = new House("Hufflepuff", "Badger", "Barrel near the Kitchens", huff_values, huff_colors, "The Fat Friar", "Helga Hufflepuff");

        // Slytherin
        List<string> slyth_values = new List<string>();
        slyth_values.Add("Cunning");
        slyth_values.Add("Ambition");

        List<string> slyth_colors = new List<string>();
        slyth_colors.Add("Green");
        slyth_colors.Add("Silver");

        House slytherin = new House("Slytherin", "Snake", "Stone wall in the Dungeons", slyth_values, slyth_colors, "The Bloody Baron", "Salazar Slytherin");

        List<House> houses = new List<House>();
        houses.Add(gryffindor);
        houses.Add(ravenclaw);
        houses.Add(hufflepuff);
        houses.Add(slytherin);

        // Create Hogwarts school
        School hogwarts = new School("Hogwarts", "Draco Dormiens Nunquam Titillandus", houses);


        // Start the adventure
        System.Console.WriteLine();
        System.Console.WriteLine($"Welcome to your {hogwarts.GetSchoolName()} experience!! We are excited for you to start school this semester!");
        System.Console.WriteLine("Since this is your first year, we'll need to gather some information about you to get you registered! ");
        System.Console.Write("Before we get started, would you like to learn a little bit about the school?(y/n) ");
        string learn = System.Console.ReadLine();
        System.Console.WriteLine();

        if (learn == "y")
        {
            System.Console.WriteLine("Okay, here's some general information about the school!\n");
            hogwarts.DisplaySchoolInfo();
            System.Console.WriteLine();
        }
        else if (learn == "n")
        {
            System.Console.WriteLine("In that case, let's continue on!\n");
        }
        else
        {
            System.Console.WriteLine("That wasn't one of the options... let's just continue along anyway.\n");
        }

        // Get student info so that we can create a new student
        // Get name first
        System.Console.Write("As a new student, we will need to get your name. Please type it in here: ");
        string student_name = System.Console.ReadLine();
        System.Console.WriteLine($"Great! Welcome to {hogwarts.GetSchoolName()} {student_name}!\n");

        // Next get the year (keep looping until they enter something between 1 and 7)
        int student_year = -1;
        while(0 >= student_year || student_year >= 8)
        {
            System.Console.WriteLine("We also need to know what year you will be starting school!");
            System.Console.Write($"{hogwarts.GetSchoolName()} offers school for years 1-7. Please type in which year you will be starting out at: ");
            string str_student_year = System.Console.ReadLine();
            student_year = Int32.Parse(str_student_year);
        }

        // Last get their chosen house
        System.Console.WriteLine("Excellent! Just one more thing before we can add you to the system.");
        System.Console.WriteLine("We need to know which house you would like to join! Keep in mind, this cannot be changed.");
        System.Console.WriteLine($"Your house will be your home and family for all your years at {hogwarts.GetSchoolName()}.");

        System.Console.WriteLine($"The houses you can chose from are: ");
        hogwarts.DisplayHouseNames();

        System.Console.Write("Please type in the number of the house you would like to join: ");
        int stud_house_index = -1;
        string str_stud_house_index = System.Console.ReadLine();
        stud_house_index = Int32.Parse(str_stud_house_index);
        stud_house_index --;

        House student_house = houses[stud_house_index];

        // Create the student!
        Student s1 = new Student(student_name, student_year, student_house);

        System.Console.WriteLine($"Great! You are now in the system!\n");

        // Get pet info and add it to the student
        System.Console.WriteLine("We wanted to ask you a few more questions about you to include in our records. ");
        System.Console.Write($"First, will you be bringing a pet with you to {hogwarts.GetSchoolName()}?(y/n) ");
        string has_pet = "x";

        while(has_pet != "y" || has_pet != "n")
        {
            System.Console.Write($"First, will you be bringing a pet with you to {hogwarts.GetSchoolName()}?(y/n) ");
            has_pet = System.Console.ReadLine();

            if(has_pet == "y")
            {
                string pet_type = "0";
                while(pet_type != "1" || pet_type != "2" || pet_type != "3")
                {
                    System.Console.WriteLine($"Great! You have three options for pets:\n1. Owl\n2. Cat\n3. Toad\n");
                    System.Console.Write("Which one would you like? (please enter the number) ");
                    pet_type = System.Console.ReadLine();

                    // Create an Owl and add to student
                    if(pet_type == "1")
                    {
                        System.Console.Write("\nWhat is the name of your owl? ");
                        string owl_name = System.Console.ReadLine();
                        System.Console.Write("What color feathers does your owl have? ");
                        string feather_color = System.Console.ReadLine();
                        Owl s1_owl = new Owl(owl_name, feather_color);
                        s1.SetPet(s1_owl);
                    }

                    // Create a Cat and add to student
                    else if(pet_type == "2")
                    {
                        System.Console.Write("\nWhat is the name of your cat? ");
                        string cat_name = System.Console.ReadLine();
                        System.Console.Write("What color fur does your cat have? ");
                        string fur_color = System.Console.ReadLine();
                        Cat s1_cat = new Cat(fur_color, cat_name);
                        s1.SetPet(s1_cat);
                    }

                    // Create a Toad and add to student
                    else if(pet_type == "3")
                    {
                        System.Console.Write("\nWhat is the name of your toad? ");
                        string toad_name = System.Console.ReadLine();
                        System.Console.Write("Is your toad spotted?(y/n) ");
                        string str_is_spotted = System.Console.ReadLine();
                        bool is_spotted;
                        if(str_is_spotted == "y")
                        {
                            is_spotted = true;
                        }
                        else if(str_is_spotted == "n")
                        {
                            is_spotted = false;
                        }
                        else
                        {
                            System.Console.WriteLine("Invalid entry. We will assume your toad is spotted. ");
                            is_spotted = true;
                        }
                        Toad s1_toad = new Toad(is_spotted, toad_name);
                        s1.SetPet(s1_toad);
                    }
                    else
                    {
                        System.Console.WriteLine("That was not one of the animal options. Please try again, and this time enter 1 2 or 3 only.");
                    }
                } 
            }
            else if(has_pet == "n")
            {
                System.Console.WriteLine("Okay, we'll continue forward then. ");
            }
            else
            {
                System.Console.WriteLine("That wasn't one of the options. Please type y or n only.");
            }
        }

        // Get wand attributes and create a wand
        System.Console.WriteLine($"\nWe would also like to know about your wand.");
        System.Console.WriteLine("Each wand is unique and has unique attributes. Please, tell us about your wand. ");
        System.Console.Write("What type of wood is your wand made of? ");
        string wand_wood = System.Console.ReadLine();
        System.Console.Write("What is the core of your wand made of? ");
        string wand_core = System.Console.ReadLine();
        System.Console.Write("What is the length of your wand? ");
        string wand_length = System.Console.ReadLine();
        System.Console.Write("What is the flexibility of your wand? ");
        string wand_flex = System.Console.ReadLine();

        Wand s1_wand = new Wand(wand_wood, wand_core, wand_length, wand_flex);
        s1.SetWand(s1_wand);

        System.Console.WriteLine($"\nGreat! We have all the wand information we need! Your wand info has been added to your account.");

        System.Console.WriteLine($"\n\nCongratulations, your general setup is complete!");

    }
}
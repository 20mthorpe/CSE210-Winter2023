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
        System.Console.WriteLine($"Welcome to your {hogwarts.GetSchoolName()} experience!! We are excited for you to start school this semester!");
        System.Console.WriteLine("Since this is your first year, we'll need to gather some information about you to get you registered! ");
        System.Console.WriteLine("Before we get started, would you like to learn a little bit about the school?(y/n) ");
        string learn = System.Console.ReadLine();

        if (learn == "y")
        {
            System.Console.WriteLine("Okay, here's some general information about the school! ");
            hogwarts.DisplaySchoolInfo();
        }
        else if (learn == "n")
        {
            System.Console.WriteLine("In that case, let's continue on! ");
        }
        else
        {
            System.Console.WriteLine("That wasn't one of the options... let's just continue along anyway.");
        }

        // Get student info so that we can create a new student
        // Get name first
        System.Console.Write("As a new student, we will need to get your name. Please type it in here: ");
        string student_name = System.Console.ReadLine();
        System.Console.WriteLine($"Great! Welcome to {hogwarts.GetSchoolName()} {student_name}!\n");

        // Next get the year (keep looping until they enter something between 1 and 7)
        int student_year = -1;
        while(0 >= student_year || student_year <= 8)
        {
            System.Console.WriteLine("We also need to know what year you will be starting school!");
            System.Console.Write($"{hogwarts.GetSchoolName()} offers school for years 1-7. Please type in which year you will be starting out at: ");
            string str_student_year = System.Console.ReadLine();
            student_year = Int32.Parse(str_student_year);
        }

        // Last get their chosen house
        System.Console.WriteLine("Excellent! Just one more thing before we can add you to the system.");
        System.Console.WriteLine("We need to know which house you would like to join! Keep in mind, this cannot be changed.");
        System.Console.WriteLine($"Your house will be your home and family for all your years at {hogwarts.GetSchoolName}.");

        System.Console.WriteLine($"The houses you can chose from are: ");
        System.Console.WriteLine($"{hogwarts.DisplayHouseNames}");

        System.Console.Write("Please type in the number of the house you would like to join: ");
        int stud_house_index = -1;
        string str_stud_house_index = System.Console.ReadLine();
        stud_house_index = Int32.Parse(str_stud_house_index);

        House student_house = houses[stud_house_index];

        // Create the student!
        Student s1 = new Student(student_name, student_year, student_house);

        System.Console.WriteLine("Great! You are now in the system! ");

    }
}
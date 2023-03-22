using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");

        List<string> gryf_values = new List<string>();
        gryf_values.Add("Bravery");
        gryf_values.Add("Chivalry");

        List<string> gryf_colors = new List<string>();
        gryf_colors.Add("Scarlet");
        gryf_colors.Add("Gold");

        House gryffindor = new House("Gryffindor", "Lion", "Fat Lady in the Pink Dress", gryf_values, gryf_colors);

        List<string> raven_values = new List<string>();
        raven_values.Add("Wit");
        gryf_values.Add("Learning");

        List<string> raven_colors = new List<string>();
        raven_colors.Add("Blue");
        raven_colors.Add("Bronze");

        House ravenclaw = new House("Ravenclaw", "Eagle", "Door of Riddles", raven_values, raven_colors);

        List<string> huff_values = new List<string>();
        huff_values.Add("Loyalty");
        huff_values.Add("Hard-Working");

        List<string> huff_colors = new List<string>();
        huff_colors.Add("Yellow");
        huff_colors.Add("Black");

        House hufflepuff = new House("Hufflepuff", "Badger", "Barrel near the Kitchens", huff_values, huff_colors);

        List<string> slyth_values = new List<string>();
        slyth_values.Add("Cunning");
        slyth_values.Add("Ambition");

        List<string> slyth_colors = new List<string>();
        slyth_colors.Add("Green");
        slyth_colors.Add("Silver");

        House slytherin = new House("Slytherin", "Snake", "Stone wall in the Dungeons", slyth_values, slyth_colors);

        List<House> houses = new List<House>();
        houses.Add(gryffindor);
        houses.Add(ravenclaw);
        houses.Add(hufflepuff);
        houses.Add(slytherin);

        School hogwarts = new School("Hogwarts", "Draco Dormiens Nunquam Titillandus", houses);

        

    }
}
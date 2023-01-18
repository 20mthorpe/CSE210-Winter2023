using System;

// Shopping Cart Program
/*
1) Add Item
2) Display
3) Total
4) Remove
5) Quit
*/

// Person
// - name(s)
// - birth date(s)
// - gender


/*
class Person
{
    public string name;
    public string birth;
    public string gender;

    List<string> names;

    public string GetGender()
    {
        return this.gender;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person fred = new Person();
        fred.name = "Fred";
        System.Console.WriteLine(fred.GetGender());

    }
}
*/

class Program
{
    static void Main(string[] args)
    {
        List<string> items = new List<string>();
        List<float> prices = new List<float>();

        bool done = false;
        while (!done)
        {
            DisplayMenu();
            int choice = GetChoice();

            if (choice == 1)
            {
                AddItem(items, prices);
            }
            if (choice == 2)
            {
                Display(items, prices);
            }
            if (choice == 5)
            {
                done = true;
            }

            /*
            switch (choice)
            {
                case 1:
                    AddItem(items, prices);
                    break;
                case 2:
                    Display(items, prices);
                    break;
                case 5:
                    done = false;
                    break;
            }
            */

        }
    }

    static void DisplayMenu()
    {
        System.Console.WriteLine("1) Add Item");
        System.Console.WriteLine("2) Display");
        System.Console.WriteLine("3) Total");
        System.Console.WriteLine("4) Remove");
        System.Console.WriteLine("5) Quit");
    }
    static int GetChoice()
    {
        System.Console.Write("Enter Choice: ");
        string choice = Console.ReadLine();
        int answer = int.Parse(choice);
        return answer;
    }
    static void AddItem(List<string> items, List<float> prices)
    {
        System.Console.Write("Enter Item: ");
        string item = Console.ReadLine();

        System.Console.Write("Enter Price: ");
        string priceInput = Console.ReadLine();
        float price = float.Parse(priceInput);

        items.Add(item);
        prices.Add(price);
    }

    static void Display(List<string> items, List<float> prices)
    {
        for (int i = 0; i < items.Count; i++)
        {
            System.Console.WriteLine($"{items[i]}: {prices[i]}");
        }
        System.Console.WriteLine("");
    }

}
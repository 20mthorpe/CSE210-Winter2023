using System;

class ListeningActivity : Activity
{
    private List<string> _items = new List<string>();
    private string _prompt;

    public ListeningActivity(int duration) : base("Listening Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration)
    {

    }

    public void SetRandomPrompt()
    {
        List<string> prompts = new List<string>();
        prompts.Add("What are some of your favorite foods? ");
        prompts.Add("What good things have happened today? ");
        prompts.Add("Who in your life are you grateful for? ");
        prompts.Add("What things make you happy? ");
        prompts.Add("What things help you to feel the spirit? ");
        prompts.Add("What hobbies make you happy? ");
        prompts.Add("Who in your life makes you laugh the most? ");

        Random rand = new Random();
        int randIndex = rand.Next(prompts.Count);

        _prompt = (prompts[randIndex]);
    }
    public void GetItems()
    {
        var watch = new System.Diagnostics.Stopwatch();
        double totalMilliseconds = 0;
        watch.Start();

        while (totalMilliseconds < (_duration*1000))
        {
            string item;
            item = Console.ReadLine();
            _items.Add(item);
            watch.Stop();
            double milliseconds = watch.ElapsedMilliseconds;
            totalMilliseconds += milliseconds;
        }
    }
    public void DisplayRandomPrompt()
    {
        System.Console.WriteLine();
        System.Console.WriteLine("List as many responses you can to the following prompt: ");
        System.Console.WriteLine($"  --- {_prompt} ---  ");
    }
    public void DisplayItemAmount()
    {
        System.Console.WriteLine($"You listed {_items.Count} item(s).");
    }

}
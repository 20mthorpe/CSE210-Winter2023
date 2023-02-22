using System;

class ReflectingActivity : Activity
{
    private string _prompt;
    private string _promptQuestion;

    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }
    public void GetRandomPrompt()
    {
        _prompt = ("This is a random prompt for now");
    }
    
    // pass in the prompt so that the question about it can be specific?
    public void GetPromptQuestion()
    {
        _promptQuestion = ("This is a question about the prompt");
    }
    public void DisplayPrompt()
    {
        System.Console.WriteLine(_prompt);
    }
    public void DisplayPromptQuestion()
    {
        System.Console.WriteLine(_promptQuestion);
    }
}
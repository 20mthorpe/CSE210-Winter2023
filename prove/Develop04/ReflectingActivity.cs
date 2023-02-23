using System;

class ReflectingActivity : Activity
{
    private string _prompt;
    private string _promptQuestion;

    public ReflectingActivity(int duration) : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", duration)
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
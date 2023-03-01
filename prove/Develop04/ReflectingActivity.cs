using System;
using System.Collections.Generic;

class ReflectingActivity : Activity
{
    private string _prompt;
    private string _promptQuestion;

    public ReflectingActivity(int duration) : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", duration)
    {

    }
    public void SetRandomPrompt()
    {
        List<string> prompts = new List<string>();
        prompts.Add("Think of a time when you did service for someone close to you. ");
        prompts.Add("Think of a time when someone served you. ");
        prompts.Add("Think of a time when you felt a deep love for someone. ");
        prompts.Add("Think of a time when you had to do something difficult. ");
        prompts.Add("Think of a time when you overcame adversity. ");
        prompts.Add("Think of a time when you had to give something up. ");
        prompts.Add("Think of a time when you followed your intuition. ");

        Random rand = new Random();
        int randIndex = rand.Next(prompts.Count);

        _prompt = (prompts[randIndex]);
    }
    
    // pass in the prompt so that the question about it can be specific?
    public void SetPromptQuestion()
    {
        List<string> promptQuestions = new List<string>();
        promptQuestions.Add("How did that make you feel? ");
        promptQuestions.Add("What did you learn from that experience? ");
        promptQuestions.Add("How did that experience have a positive effect on you? ");
        promptQuestions.Add("How did that experience help you to grow? ");
        promptQuestions.Add("How did that experience affect the people around you? ");
        promptQuestions.Add("Did your family, or the people close to you, see a difference in you after you had this experience? ");
        promptQuestions.Add("Has the experience gained greater meaning since you first had it? ");

        Random rand = new Random();
        int randIndex = rand.Next(promptQuestions.Count);

        _promptQuestion = (promptQuestions[randIndex]);
    }
    public void DisplayPrompt()
    {
        System.Console.WriteLine();
        System.Console.WriteLine(_prompt);
        System.Console.WriteLine();
    }
    public void DisplayPromptQuestion()
    {
        System.Console.WriteLine(_promptQuestion);
    }
}
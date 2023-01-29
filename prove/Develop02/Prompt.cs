using System;

class Prompt
{

    public List<string> createPromptsList()
    {
        List<string> prompts = new List<string>();

        prompts.Add("What has brought you joy today?");
        prompts.Add("What was your greatest fear, and how did you conquer it?");
        prompts.Add("Write a letter to someone that you always want to thank but have never had the chance to do so.");
        prompts.Add("What is something that you would like to change about yourself?");
        prompts.Add("Why are friends so important?");
        prompts.Add("Why is family so important?");
        prompts.Add("Describe Sundays at your house.");

        return prompts;
    }
    public int GetRandomNum()
    {
        Random random = new Random();
        List<string> prompts = createPromptsList();
        int randomNum = random.Next(0, prompts.Count());
        return randomNum;
    }
    public void DisplayRandomPrompt()
    {
        int randomNum = GetRandomNum();
        List<string> prompts = createPromptsList();
        Console.WriteLine(prompts.ElementAt(randomNum));
    }
}
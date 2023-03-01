using System;

class BodyScanActivity : Activity
{

    public BodyScanActivity(int duration) : base("Body Scan Activity", "This activity will help you relax by helping you to be aware of your muscles and body. Clear your mind and focus on your body.", duration)
    {
        
    }

    public void RunScan()
    {
        System.Console.WriteLine("Get into a comfortable position. ");
        DisplayDelay(3);
        System.Console.WriteLine();
        System.Console.WriteLine("Start at your feet and toes. ");
        System.Console.WriteLine("Pay attention to any sensations you feel. ");
        DisplayDelay(_duration/5);
        System.Console.WriteLine();
        System.Console.WriteLine("Move up to your legs. ");
        System.Console.WriteLine("Pay attention to any sensations you feel. ");
        DisplayDelay(_duration/5);
        System.Console.WriteLine();
        System.Console.WriteLine("Move up to your torso. ");
        System.Console.WriteLine("Pay attention to any sensations you feel. ");
        DisplayDelay(_duration/5);
        System.Console.WriteLine();
        System.Console.WriteLine("Move to your arms and hands. ");
        System.Console.WriteLine("Pay attention to any sensations you feel. ");
        DisplayDelay(_duration/5);
        System.Console.WriteLine();
        System.Console.WriteLine("Finally, move up to your head. ");
        System.Console.WriteLine("Pay attention to any sensations you feel. ");
        DisplayDelay(_duration/4);

    }
    

}
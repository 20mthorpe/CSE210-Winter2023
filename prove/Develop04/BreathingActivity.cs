using System;

class BreathingActivity : Activity
{

    private int time = 0;
    public BreathingActivity(int duration) : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", duration)
    {
        
    }

    private void CountDown(int count)
    {
        count -= 1;
        for (int i = count; i>=0; i--)
        {
            Thread.Sleep(1000);
            time += 1;
            System.Console.Write("\b \b");
            System.Console.Write(i);
        }

    }
    public void DisplayCountdown()
    {
        time = 0;

        while (time < _duration){

            System.Console.WriteLine();
            
            int BreatheInCount = 4;
            System.Console.WriteLine();
            System.Console.Write($"Breathe In... {BreatheInCount}");
            CountDown(BreatheInCount);

            int HoldCount = 7;
            System.Console.WriteLine();
            System.Console.Write($"Hold It... {HoldCount}");
            CountDown(HoldCount);

            int BreatheOutCount = 8;
            System.Console.WriteLine();
            System.Console.Write($"Breathe Out... {BreatheOutCount}");
            CountDown(BreatheOutCount);
            System.Console.WriteLine();

        }
    }

//    public void DisplayCountdown()
//    {
//        int time = 0;
//
//        while (time < _duration){
//
//            System.Console.WriteLine();
//            System.Console.Write("Breathe In... 4");
//            Thread.Sleep(1000);
//            time += 1;
//            System.Console.Write("\b \b");
//            System.Console.Write("3");
//            Thread.Sleep(1000);
//            time += 1;
//            System.Console.Write("\b \b");
//            System.Console.Write("2");
//            Thread.Sleep(1000);
//            time += 1;
//            System.Console.Write("\b \b");
//            System.Console.Write("1");
//            Thread.Sleep(1000);
//            time += 1;
//            System.Console.Write("\b \b");
//
//            System.Console.WriteLine();
//            System.Console.Write("Hold It... 7");
//            Thread.Sleep(1000);
//            time += 1;
//            System.Console.Write("\b \b");
//            System.Console.Write("6");
//            Thread.Sleep(1000);
//            time += 1;
//            System.Console.Write("\b \b");
//            System.Console.Write("5");
//            Thread.Sleep(1000);
//            time += 1;
//            System.Console.Write("\b \b");
//            System.Console.Write("4");
//            Thread.Sleep(1000);
//            time += 1;
//            System.Console.Write("\b \b");
//            System.Console.Write("3");
//            Thread.Sleep(1000);
//            time += 1;
//            System.Console.Write("\b \b");
//            System.Console.Write("2");
//            Thread.Sleep(1000);
//            time += 1;
//            System.Console.Write("\b \b");
//            System.Console.Write("1");
//            Thread.Sleep(1000);
//            time += 1;
//            System.Console.Write("\b \b");
//
//            System.Console.WriteLine();
//            System.Console.Write("Breathe Out... 8");
//            Thread.Sleep(1000);
//            time += 1;
//            System.Console.Write("\b \b");
//            System.Console.Write("7");
//            Thread.Sleep(1000);
//            time += 1;
//            System.Console.Write("\b \b");
//            System.Console.Write("6");
//            Thread.Sleep(1000);
//            time += 1;
//            System.Console.Write("\b \b");
//            System.Console.Write("5");
//            Thread.Sleep(1000);
//            time += 1;
//            System.Console.Write("\b \b");
//            System.Console.Write("4");
//            Thread.Sleep(1000);
//            time += 1;
//            System.Console.Write("\b \b");
//            System.Console.Write("3");
//            Thread.Sleep(1000);
//            time += 1;
//            System.Console.Write("\b \b");
//            System.Console.Write("2");
//            Thread.Sleep(1000);
//            time += 1;
//            System.Console.Write("\b \b");
//            System.Console.Write("1");
//            Thread.Sleep(1000);
//            time += 1;
//            System.Console.Write("\b \b");
//
//        }
//    }

}
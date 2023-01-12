using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randomNum = randomGenerator.Next(1, 100);
        int number = 0;

        do{
            Console.Write("What is your guess? ");
            string input = Console.ReadLine();
            number = Int16.Parse(input);

            if (number < randomNum){
                Console.WriteLine("Higher");
            }
            else if (number > randomNum){
                Console.WriteLine("Lower");
            }
        } while (number != randomNum);

        Console.WriteLine("You guessed it! ");

    }

}
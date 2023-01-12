using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int numberInput = 1;

        while (numberInput != 0){

            Console.Write("Enter Number: ");
            string input = Console.ReadLine();
            numberInput = int.Parse(input);

            if (numberInput != 0){
                numbers.Add(numberInput);
            }
        }

        int sum = 0;
        int avg = 0;
        int largest = 0;
        int smallest = 100;

        foreach (int number in numbers){
            sum += number;
            if (number > largest){
                largest = number;
            }
            if ((number < smallest) && (number > 0)){
                smallest = number;
            }

        }
        avg = sum / numbers.Count;
        numbers.Sort();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest number is: {smallest}");
        Console.WriteLine($"The sorted list is:");

        foreach (int number in numbers){
            Console.WriteLine(number);
        }

    }
}
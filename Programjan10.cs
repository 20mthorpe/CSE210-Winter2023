using System;
using System.Collections.Generic;

// while loops
int x = 0;
while (x < 10)
{
    System.Console.WriteLine(x);
    x++;
}

// 'do while' does it once before checking the conditions (does not exist in python)
int y = 0;
do
{
    System.Console.WriteLine(y);
    y++;
} while (y < 10);

// for loops
// the i here only exists within this for loop
for (int i = 10; i < 40; i += 7)
{
    System.Console.WriteLine(i);
}

// the i here is now global
int i;
for (i = 10; i < 40; i += 7)
{
    System.Console.WriteLine(i);
}

// if you don't include a step nothing happens (in python it adds one)

// foreach for lists
string[] cars = {"Volkswagen", "BMW", "Ford", "Volvo"};
foreach (string car in cars)
{
    Console.WriteLine(car);
}

Random randomGenerator = new Random();
int number = randomGenerator.Next(1, 11);

// List
int value;
List<int> items = new List<int>();
for (int i = 0; i < 1000; i++)
{
    items.Add(123);
}
System.Console.WriteLine(items.Count);

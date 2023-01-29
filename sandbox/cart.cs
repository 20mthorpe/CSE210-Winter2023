using System;
using System.Collections.Generic;

// Shopping cart program with classes
class Cart
{
    public List<Item> _items = new List<Item>();
    public void Display()
    {
        System.Console.WriteLine("Cart -------");
        foreach (Item item in _items)
        {
            item.Display();
        }
    }

    public void AddItem()
    {
        System.Console.Write("Enter Description: ");
        string desc = Console.ReadLine();

        System.Console.Write("Enter Price: ");
        float price = float.Parse(Console.ReadLine());

        System.Console.Write("Enter Count: ");
        int count = int.Parse(Console.ReadLine());

        Item newItem = new Item();
        newItem._desc = desc;
        newItem._price = price;
        newItem._count = count;

        _items.Add(newItem);
    }
    public void RemoveItem()
    {

    }
    public void SearchItem()
    {

    }
    public void CalculateTotal()
    {
        float total = 0;
        foreach (Item item in _items)
        {
            total += item._price;
        }
        return total;

    }

}
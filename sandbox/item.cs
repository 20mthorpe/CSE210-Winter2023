using System;
using System.Collections.Generic;

// Shopping cart program with classes
class Item
{
    public string _desc = "";
    public float _price = 0F;
    public int _count = 0;
    
    public void Display()
    {
        System.COnsole.WriteLine($"{_desc}, {_price}, {_count}");
    }
}
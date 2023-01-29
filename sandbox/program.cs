using System;
using System.Collections.Generic;

// Shopping cart program with classes
class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Cart cart = new Cart();

        menu.Display();

        cart.AddItem();
        cart.Display();
    }
}
using StrategyPattern.Models;
using StrategyPattern.Strategies;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();

            Item i1 = new Item("The Wind That Shakes The Barley", 10.99, 2);
            Item i2 = new Item("Saving Private Ryan", 15.99, 3);

            cart.AddItem(i1);
            cart.AddItem(i2);

            cart.Pay(new CreditCardStrategy("John", "789652325", "356", new DateTime()));

            //---------------------------------------------------------------------------------
            ShoppingCart cart2 = new ShoppingCart();

            Item i21 = new Item("The Wind That Shakes The Barley", 10.99, 5);
            Item i22 = new Item("Saving Private Ryan", 15.99, 1);

            cart2.AddItem(i21);
            cart2.AddItem(i22);

            cart2.Pay(new PayPalStrategy("Mary", "kodsmnd83nm39"));

        }
    }
}

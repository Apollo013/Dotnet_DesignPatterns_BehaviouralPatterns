using StrategyPattern.Strategies;
using System.Collections.Generic;

namespace StrategyPattern.Models
{
    /// <summary>
    /// Represents the 'Context'
    /// </summary>
    public class ShoppingCart
    {
        private List<Item> cart = new List<Item>();
        public void AddItem(Item item)
        {
            this.cart.Add(item);
        }

        public void RemoveItem(Item item)
        {
            this.cart.Remove(item);
        }

        public double CalculateTotal()
        {
            double sum = 0;
            foreach (Item item in cart)
            {
                sum += item.CalculateItemTotal();
            }
            return sum;
        }

        public void Pay(IPaymentStrategy paymentMethod)
        {
            double amount = CalculateTotal();
            paymentMethod.Pay(amount);
        }
    }
}

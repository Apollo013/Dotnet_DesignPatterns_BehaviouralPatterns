using System;

namespace StrategyPattern.Strategies
{
    public class PayPalStrategy : IPaymentStrategy
    {
        private string _name;
        private string _password;

        public PayPalStrategy(string name, string password)
        {
            _name = name;
            _password = password;
        }

        public void Pay(double amount)
        {
            Console.WriteLine($"Amount: {amount,-12} Payment made using Paypal account for {_name}");
        }
    }
}

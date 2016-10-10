using System;

namespace StrategyPattern.Strategies
{
    public class CreditCardStrategy : IPaymentStrategy
    {
        private string _name;
        private string _cardNumber;
        private string _securityCode;
        private DateTime _expiryDate;

        public CreditCardStrategy(String name, String cardNumber, String securityCode, DateTime expiryDate)
        {
            _name = name;
            _cardNumber = cardNumber;
            _securityCode = securityCode;
            _expiryDate = expiryDate;
        }

        public void Pay(double amount)
        {
            Console.WriteLine($"Amount: {amount,-12} Payment made using credit card for {_name}");
        }
    }
}

using ObserverPattern.Subjects;
using System;

namespace ObserverPattern.Observers
{
    public class Investor : IInvestor
    {
        public string Name { get; set; }
        public Stock Stock { get; set; }

        public Investor(string name)
        {
            Name = name;
        }
        public void Update(Stock stock)
        {
            Console.WriteLine($"{Name,-10}: Notified of price change for {stock.Ticker,-10}; New Price:{stock.Price}");
        }
    }
}

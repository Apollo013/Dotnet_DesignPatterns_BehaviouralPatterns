using ObserverPattern.Observers;
using System.Collections.Generic;

namespace ObserverPattern.Subjects
{
    public class Stock
    {
        private List<IInvestor> investors = new List<IInvestor>();
        public string Ticker { get; private set; }

        private double price;
        public double Price
        {
            get { return price; }
            set
            {
                if (price != value)
                {
                    price = value;
                    Notify();
                }

            }
        }

        public Stock(string ticker, double price)
        {
            Ticker = ticker;
            this.price = price;
        }

        public void Attach(IInvestor investor)
        {
            investors.Add(investor);
        }

        public void Detach(IInvestor investor)
        {
            investors.Remove(investor);
        }

        /// <summary>
        /// Notify investors of any price changes
        /// </summary>
        public void Notify()
        {
            string divider = new string('-', 100);

            System.Console.WriteLine();
            System.Console.WriteLine(divider);
            System.Console.WriteLine("Price Change");
            System.Console.WriteLine(divider);

            foreach (var investor in investors)
            {
                investor.Update(this);
            }
        }
    }
}

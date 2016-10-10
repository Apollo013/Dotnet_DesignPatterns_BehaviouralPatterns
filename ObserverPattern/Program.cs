using ObserverPattern.Observers;
using ObserverPattern.Subjects;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create subject
            Stock stock = new IBMStock("IBM", 21.76);

            // Create observers
            IInvestor investor = new Investor("Investor 1");
            IInvestor investor2 = new Investor("Investor 2");

            // Attach observers to subject
            stock.Attach(investor);
            stock.Attach(investor2);

            // Update prices (will notify investors)
            stock.Price = 21.80;
            stock.Price = 21.86;
            stock.Price = 21.90;
            stock.Price = 21.99;
        }
    }
}


namespace ObserverPattern.Subjects
{
    public class IBMStock : Stock
    {
        public IBMStock(string ticker, double price) : base(ticker, price)
        { }
    }
}

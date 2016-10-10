namespace StrategyPattern.Strategies
{
    /// <summary>
    /// Represents the 'Algorithm' strategy
    /// </summary>
    public interface IPaymentStrategy
    {
        void Pay(double ammount);
    }
}

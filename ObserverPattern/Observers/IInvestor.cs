using ObserverPattern.Subjects;

namespace ObserverPattern.Observers
{
    /// <summary>
    /// Observer interface
    /// </summary>
    public interface IInvestor
    {
        void Update(Stock stock);
    }
}

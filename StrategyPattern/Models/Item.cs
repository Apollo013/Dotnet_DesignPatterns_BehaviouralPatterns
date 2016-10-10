namespace StrategyPattern.Models
{

    public class Item
    {
        protected string Name { get; set; }
        protected double CostPriceEach { get; set; }
        protected int Quantity { get; set; }

        public Item(string name, double costPriceEach, int quantity)
        {
            Name = name;
            CostPriceEach = costPriceEach;
            Quantity = quantity;
        }

        public double CalculateItemTotal()
        {
            return Quantity * CostPriceEach;
        }
    }
}

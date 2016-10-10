namespace StrategyPattern.Models
{

    public class Item
    {
        public string Name { get; set; }
        public double CostPriceEach { get; set; }
        public int Quantity { get; set; }

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

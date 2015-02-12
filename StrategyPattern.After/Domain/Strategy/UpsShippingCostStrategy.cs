namespace StrategyPattern.After.Test
{
    public class UpsShippingCostStrategy : IShippingCostStrategy
    {
        public double Calculate(Order order)
        {
            return 3.00d;
        }
    }
}
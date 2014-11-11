namespace StrategyPattern.After.Test
{
    public class DhlShippingCostStrategy : IShippingCostStrategy
    {
        public double Calculate(Order order)
        {
            return 4.00d;
        }
    }
}
namespace StrategyPattern.After
{
    public interface IShippingCostStrategy
    {
        double Calculate(Order order);
    }
}
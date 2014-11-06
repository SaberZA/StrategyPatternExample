namespace StrategyPattern.After_Variation.Domain.ShippingService
{
    public interface IShippingCostStrategy
    {
        double Calculate(Order order);
    }
}
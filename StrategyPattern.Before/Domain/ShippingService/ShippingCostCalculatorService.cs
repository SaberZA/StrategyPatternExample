namespace StrategyPattern.After.Domain.ShippingService
{
    public class ShippingCostCalculatorService
    {
        private readonly IShippingCostStrategy shippingCostStrategy;

        public ShippingCostCalculatorService(IShippingCostStrategy shippingCostStrategy)
        {
            this.shippingCostStrategy = shippingCostStrategy;
        }

        public double CalculateShippingCost(Order order)
        {
            return shippingCostStrategy.Calculate(order);
        }
    }
}
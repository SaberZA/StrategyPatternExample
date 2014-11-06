

using System;

namespace StrategyPattern.After_Variation.Domain.ShippingService
{
    public class ShippingCostCalculatorService
    {
        public double CalculateShippingCost(Order order, Func<Order, double> strategy)
        {
            return strategy(order);
        }
    }
}


using StrategyPattern.Before;

namespace StrategyPattern.Before.Domain.ShippingService
{
    public class ShippingCostCalculatorService
    {
        public double CalculateShippingCost(Order order)
        {
            switch (order.ShippingMethod)
            {
                case Order.ShippingOptions.FedEx:
                    return CalculateForFedEx(order);
                case Order.ShippingOptions.Ups:
                    return CalculateForUps(order);
                case Order.ShippingOptions.Dhl:
                    return CalculateForDhl(order);
                default:
                    throw new UnknownOrderShippingMethodException();
            }
        }

        private double CalculateForDhl(Order order)
        {
            return 4.00d;
        }

        private double CalculateForUps(Order order)
        {
            return 3.00d;
        }

        private double CalculateForFedEx(Order order)
        {
            return 5.00d;
        }
    }
}
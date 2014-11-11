using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.After_Variation.Domain;
using StrategyPattern.After_Variation.Domain.ShippingService;


namespace StrategyPattern.After_Variation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Func<Order, double> fedExStrategy = CalculateCostForFedEx;
            Func<Order, double> upsStrategy = delegate(Order order) { return 3.00d; };
            Func<Order, double> dhlStrategy = order => 4.00d;

            Order theOrder = Broker.CreateOrder();

            var calculatorService = new ShippingCostCalculatorService();

            Console.WriteLine("FedEx Shipping Cost: {0}",
                calculatorService.CalculateShippingCost(theOrder, fedExStrategy));

            Console.WriteLine("UPS Shipping Cost: {0}",
                calculatorService.CalculateShippingCost(theOrder, upsStrategy));

            Console.WriteLine("DHL Shipping Cost: {0}",
                calculatorService.CalculateShippingCost(theOrder, dhlStrategy));

            Console.ReadKey();
        }

        private static double CalculateCostForFedEx(Order arg)
        {
            return 5.00d;
        }
    }
}

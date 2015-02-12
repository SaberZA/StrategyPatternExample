using NUnit.Framework;
using StrategyPattern.After.Domain.ShippingService;

namespace StrategyPattern.After.Test
{
    public class ShippingCostCalculatorServiceTest
    {
        [Test]
        public void CalculateShippingCost_GivenDhlOrder_ShouldReturn4Cost()
        {
            //---------------Set up test pack-------------------
            var strategy = new DhlShippingCostStrategy();
            var shippingCalculatorService = new ShippingCostCalculatorService(strategy);
            var order = Broker.CreateOrder_Dhl();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var cost = shippingCalculatorService.CalculateShippingCost(order);
            //---------------Test Result -----------------------
            Assert.AreEqual(4.00d, cost);
        }

        [Test]
        public void CalculateShippingCost_GivenFedExOrder_ShouldReturn5Cost()
        {
            //---------------Set up test pack-------------------
            var strategy = new FedExShippingCostStrategy();
            var shippingCalculatorService = new ShippingCostCalculatorService(strategy);
            var order = Broker.CreateOrder_FedEx();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var cost = shippingCalculatorService.CalculateShippingCost(order);
            //---------------Test Result -----------------------
            Assert.AreEqual(5.00d, cost);
        }

        [Test]
        public void CalculateShippingCost_GivenUpsOrder_ShouldReturn3Cost()
        {
            //---------------Set up test pack-------------------
            var strategy = new UpsShippingCostStrategy();
            var shippingCalculatorService = new ShippingCostCalculatorService(strategy);
            var order = Broker.CreateOrder_Ups();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var cost = shippingCalculatorService.CalculateShippingCost(order);
            //---------------Test Result -----------------------
            Assert.AreEqual(3.00d, cost);
        }
    }
}

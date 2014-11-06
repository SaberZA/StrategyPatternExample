using NUnit.Framework;
using StrategyPattern.Before.Domain.ShippingService;


namespace StrategyPattern.Before.Test
{
    public class ShippingCostCalculatorServiceTest
    {
        [Test]
        public void CalculateShippingCost_GivenDhlOrder_ShouldReturn4Cost()
        {
            //---------------Set up test pack-------------------
            var shippingCalculatorService = new ShippingCostCalculatorService();
            var order = Mother.CreateOrder_Dhl();
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
            var shippingCalculatorService = new ShippingCostCalculatorService();
            var order = Mother.CreateOrder_FedEx();
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
            var shippingCalculatorService = new ShippingCostCalculatorService();
            var order = Mother.CreateOrder_Ups();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var cost = shippingCalculatorService.CalculateShippingCost(order);
            //---------------Test Result -----------------------
            Assert.AreEqual(3.00d, cost);
        }
    }
}

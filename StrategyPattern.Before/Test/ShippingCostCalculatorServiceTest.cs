using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace StrategyPattern.Before
{
    public class ShippingCostCalculatorServiceTest
    {
        [Test]
        public void CalculateShippingCost_GivenDhlOrder_ShouldReturn425Cost()
        {
            //---------------Set up test pack-------------------
            var shippingCalculatorService = new ShippingCostCalculatorService();
            var order = Mother.CreateOrder_Dhl();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var cost = shippingCalculatorService.CalculateShippingCost(order);
            //---------------Test Result -----------------------
            Assert.AreEqual(4.25d, cost);
        }
    }

    public class Mother
    {
        public static Order CreateOrder_Dhl()
        {
            return new Order
                {
                    ShippingMethod = Order.ShippingOptions.Ups,
                    Destination = Mother.CreateAddress_Destination(),
                    Origin = Mother.CreateAddress_Origin()
                };
        }

        private static Address CreateAddress_Origin()
        {
            return new Address
                {
                    ContactName = "Steven van der Merwe",
                    AddressLine1 = "19 Chapman Road",
                    AddressLine2 = "Pietermaritzburg"
                };
        }

        private static Address CreateAddress_Destination()
        {
            return new Address
                {
                    ContactName = "Darren Whitfield",
                    AddressLine1 = "25 Timmy road",
                    AddressLine2 = "Durban"
                };
        }
    }

    public class Address
    {
        public string ContactName { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }
    }

    public class Order
    {
        public Order.ShippingOptions ShippingMethod { get; set; }

        public Address Destination { get; set; }

        public Address Origin { get; set; }

        public enum ShippingOptions
        {
            Ups,
            FedEx,
            Dhl
        }
    }

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
            return 4.25d;
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

    public class UnknownOrderShippingMethodException : Exception
    {
    }
}

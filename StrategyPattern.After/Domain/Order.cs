namespace StrategyPattern.After
{
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
}
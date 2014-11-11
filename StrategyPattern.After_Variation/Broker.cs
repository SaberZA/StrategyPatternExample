using StrategyPattern.After_Variation.Domain;

namespace StrategyPattern.After_Variation
{
    public class Broker
    {
        public static Order CreateOrder_Dhl()
        {
            return new Order
                {
                    ShippingMethod = Order.ShippingOptions.Dhl,
                    Destination = Broker.CreateAddress_Destination(),
                    Origin = Broker.CreateAddress_Origin()
                };
        }

        private static Address CreateAddress_Origin()
        {
            return new Address
                {
                    ContactName = "Steven van der Merwe",
                    AddressLine1 = "19 Daffy Road",
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

        public static Order CreateOrder_FedEx()
        {
            return new Order
            {
                ShippingMethod = Order.ShippingOptions.FedEx,
                Destination = Broker.CreateAddress_Destination(),
                Origin = Broker.CreateAddress_Origin()
            };
        }

        public static Order CreateOrder_Ups()
        {
            return new Order
            {
                ShippingMethod = Order.ShippingOptions.Ups,
                Destination = Broker.CreateAddress_Destination(),
                Origin = Broker.CreateAddress_Origin()
            };
        }

        public static Order CreateOrder()
        {
            return new Order
            {
                Destination = Broker.CreateAddress_Destination(),
                Origin = Broker.CreateAddress_Origin()
            };
        }
    }
}
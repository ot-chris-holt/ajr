using System;

namespace AJr.Domain.SingletonTypes
{
    public class ShippingMethod
    {
        public string ID { get; set; }
        public string Carrier { get; set; }
        public string Priority { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTS { get; set; }

    }
}

using System;
using System.Collections.Generic;
using AJr.Domain.SingletonTypes;

namespace AJr.Domain.AggregateTypes
{
    public class Order
    {
        public string ID { get; set; }
        public string TrackingNumber { get; set; }
        
        public Address ShippingAddress { get; set; }
        public ShippingMethod ShippingMethod { get; set; }
        public DateTime CreatedTS { get; set; }
        public List<OrderLineItem> OrderLineItems { get; set; }
        public Customer Customer { get; set; }
        //TODO: have a customer object or customer ID? or only have orders exist on the customer object?

    }
}

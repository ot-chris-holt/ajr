using System;
using System.Collections.Generic;
using AJr.Domain.Enums;

namespace AJr.Domain
{
    public class Order
    {
        public virtual Guid Id { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual CarrierName Carrier { get; set; }
        public virtual Address ShippingAddress { get; set; }
        public virtual DateTime CreatedOn { get; set; }
        public virtual string TrackingNumber { get; set; }

        public virtual IList<OrderLineItem> OrderLineItems { get; set; }
    }
}

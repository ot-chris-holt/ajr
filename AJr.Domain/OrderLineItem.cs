using System;

namespace AJr.Domain
{
    public class OrderLineItem
    {
        public virtual Guid Id { get; set; }
        public virtual Product Product { get; set; }
        public virtual int Quantity { get; set; }
        public virtual decimal SellPrice { get; set; }
        public virtual decimal TotalPrice { get { return Quantity * SellPrice; } }
    }
}

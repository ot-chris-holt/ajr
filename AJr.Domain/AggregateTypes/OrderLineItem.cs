namespace AJr.Domain.AggregateTypes
{
    public class OrderLineItem
    {
        public string ID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal SellPrice { get; set; }
        public decimal TotalPrice { get { return Quantity*SellPrice; } }

    }
}

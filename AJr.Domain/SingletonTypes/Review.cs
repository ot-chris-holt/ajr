using System;

namespace AJr.Domain.SingletonTypes
{
    public class Review
    {
        public string ID { get; set; }
        public string CustomerID { get; set; }
        public string ProductID { get; set; }
        public string ReviewText { get; set; }
        public decimal GivenRating { get; set; }
        public DateTime CreatedTS { get; set; }

    }
}

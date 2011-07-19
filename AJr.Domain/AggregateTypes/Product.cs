using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AJr.Domain.SingletonTypes;

namespace AJr.Domain.AggregateTypes
{
    public class Product
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public Category Category { get; set; }
        public decimal MSRP { get; set; }
        public List<Review> Reviews { get; set; }

    }
}

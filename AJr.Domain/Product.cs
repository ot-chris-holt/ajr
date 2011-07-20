using System;
using System.Collections.Generic;

namespace AJr.Domain
{
    public class Product
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual Guid ManufacturerId { get; set; }
        public virtual Category Category { get; set; }
        public virtual decimal MSRP { get; set; }
        public virtual DateTime CreatedOn { get; set; }

        public virtual IList<Review> Reviews { get; set; }
    }
}

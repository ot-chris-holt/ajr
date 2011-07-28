using System;
using System.Collections.Generic;

namespace AJr.Domain
{
    public class Customer
    {
        public virtual Guid Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string EmailAddress { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string UserName { get; set; }
        public virtual DateTime CreatedOn { get; set; }

        public virtual IList<Address> Addresses { get; set; }
        public virtual IList<Review> Reviews { get; set; }
        public virtual IList<Order> Orders { get; set; }
    }
}

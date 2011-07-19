using System.Collections.Generic;
using AJr.Domain.SingletonTypes;

namespace AJr.Domain.AggregateTypes
{
    public class Customer
    {
        
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }

        public List<Address> Addresses { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Order> Orders { get; set; }


    }
}

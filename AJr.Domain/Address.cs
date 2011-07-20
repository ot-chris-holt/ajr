using System;
using AJr.Domain.Enums;

namespace AJr.Domain
{
    public class Address
    {
        public virtual Guid Id { get; set; }
        public virtual string Address1 { get; set; }
        public virtual string Address2 { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual string PostalCode { get; set; }
        public virtual AddressType AddressType { get; set; }
    }
}

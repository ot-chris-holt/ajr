using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AJr.Domain;
using FluentNHibernate.Mapping;

namespace AJr.Data.Mappings
{
    class CustomerMap : ClassMap<Customer>
    {
        public CustomerMap()
        {
            Id(x => x.Id);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.EmailAddress);
            Map(x => x.PhoneNumber);
            Map(x => x.UserName);
            Map(x => x.CreatedOn);
            HasMany(x => x.Orders);
            HasMany(x => x.Reviews);
            HasMany(x => x.Addresses);
        }
    }
}

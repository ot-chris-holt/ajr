using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AJr.Domain;
using FluentNHibernate.Mapping;

namespace AJr.Data.Mappings
{
    class AddressMap : ClassMap<Address>
    {
        public AddressMap()
        {
            Id(x => x.Id);
            Map(x => x.Address1);
            Map(x => x.Address2);
            Map(x => x.City);
            Map(x => x.State);
            Map(x => x.PostalCode);
            Map(x => x.AddressType);
        }
    }
}

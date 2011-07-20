using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AJr.Domain;
using FluentNHibernate.Mapping;

namespace AJr.Data.Mappings
{
    class OrderMap : ClassMap<Order>
    {
        public OrderMap()
        {
            Id(x => x.Id);
            Map(x => x.Customer);
            Map(x => x.Carrier);
            Map(x => x.TrackingNumber);
            Map(x => x.CreatedOn);

            References(x => x.ShippingAddress);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AJr.Domain;
using FluentNHibernate.Mapping;

namespace AJr.Data.Mappings
{
    class OrderLineItemMap : ClassMap<OrderLineItem>
    {
        public OrderLineItemMap()
        {
            Id(x => x.Id);
            Map(x => x.Quantity);
            Map(x => x.SellPrice);
            References(x => x.Product);
        }
    }
}

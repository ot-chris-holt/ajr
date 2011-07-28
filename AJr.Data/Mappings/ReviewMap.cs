using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AJr.Domain;
using FluentNHibernate.Mapping;

namespace AJr.Data.Mappings
{
    class ReviewMap : ClassMap<Review>
    {
        public ReviewMap()
        {
            Id(x => x.Id);
            Id(x => x.CustomerId);
            Id(x => x.ProductId);
            Map(x => x.GivenRating);
            Map(x => x.ReviewText);
            Map(x => x.CreatedOn);
        }
    }
}

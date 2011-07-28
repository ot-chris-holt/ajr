using AJr.Domain;
using FluentNHibernate.Mapping;

namespace AJr.Data.Mappings
{
    class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Id(x => x.Id);
            Id(x => x.ManufacturerId);
            Map(x => x.Name);
            Map(x => x.Description);
            Map(x => x.Category);
            Map(x => x.MSRP);
            Map(x => x.CreatedOn);
            HasMany(x => x.Reviews);
        }
    }
}

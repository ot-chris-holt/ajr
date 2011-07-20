using System;
using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.AcceptanceCriteria;
using FluentNHibernate.Conventions.Inspections;
using FluentNHibernate.Conventions.Instances;

namespace AJr.Data.Mappings
{
    class EnumConvention : IUserTypeConvention
    {
        public bool Accept(IPropertyInstance target)
        {
            return target.Property.PropertyType.IsEnum;
        }

        public void Apply(IPropertyInstance target)
        {
            target.CustomType(target.Property.PropertyType);
        }

        public bool Accept(Type type)
        {
            return type.IsEnum;
        }

        public void Accept(IAcceptanceCriteria<IPropertyInspector> criteria)
        {
            criteria.Expect(x => x.Property.PropertyType.IsEnum ||
                (x.Property.PropertyType.IsGenericType &&
                 x.Property.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) &&
                 x.Property.PropertyType.GetGenericArguments()[0].IsEnum)
                );
        }
    }
}

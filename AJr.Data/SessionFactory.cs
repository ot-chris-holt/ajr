using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AJr.Data.Mappings;
using AJr.Domain;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace AJr.Data
{
    class SessionFactoryFactory
    {
        public ISessionFactory Create()
        {
            return Fluently .Configure()
                            .Database(
                                        MsSqlConfiguration.MsSql2008
                                        .ConnectionString("7QSZSJ1/AmazonJr")
                                      )
                            .Mappings(m =>
                                        m.FluentMappings.AddFromAssemblyOf<EnumConvention>())
                            .BuildSessionFactory();
        }
    }
}

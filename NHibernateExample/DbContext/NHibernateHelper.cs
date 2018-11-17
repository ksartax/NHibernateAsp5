using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using NHibernateExample.Models;
using System.Diagnostics;

namespace NHibernateExample.DbContext
{
    public static class NHibernateHelper
    {
        private static ISessionFactory sessionFactory;
        public static ISessionFactory GetSessionFactory
        {
            get
            {
                if (sessionFactory == null)
                {
                    sessionFactory = Fluently.Configure()
                       .Database(
                               MsSqlConfiguration.MsSql2008.ConnectionString("server=(localdb)\\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True").ShowSql()
                           )
                           .Mappings(m => m.FluentMappings.AddFromAssemblyOf<User>())
                           .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Adres>())
                           .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Order>())
                           .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Product>())
                           .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Size>())

                            .ExposeConfiguration(x =>
                            {
                                x.SetInterceptor(new SqlStatementInterceptor());
                            })
                            .BuildSessionFactory();
                }

                return sessionFactory;
            }
        }

        public static ISession OpenSession => GetSessionFactory.OpenSession();
    }

    public class SqlStatementInterceptor : EmptyInterceptor
    {
        public override NHibernate.SqlCommand.SqlString OnPrepareStatement(NHibernate.SqlCommand.SqlString sql)
        {
            var a = sql.ToString();
            System.Console.WriteLine(sql.ToString());
            return sql;
        }
    }
}
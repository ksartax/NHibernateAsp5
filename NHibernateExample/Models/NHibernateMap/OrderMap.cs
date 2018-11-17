using FluentNHibernate.Mapping;

namespace NHibernateExample.Models.NHibernateMap
{
    public class OrderMap : ClassMap<Order>
    {
        public OrderMap()
        {
            Table("Orders");

            Id(a => a.Id);
            Map(a => a.TotalPrice);

            HasOne(a => a.User);
            HasMany(a => a.Products);
        }
    }
}
using FluentNHibernate.Mapping;

namespace NHibernateExample.Models.NHibernateMap
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Table("Products");

            Id(a => a.Id);
            Map(a => a.Name);
            Map(a => a.Price);

            HasManyToMany(a => a.Sizes)
                .Cascade.SaveUpdate();
        }
    }
}
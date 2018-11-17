using FluentNHibernate.Mapping;

namespace NHibernateExample.Models.NHibernateMap
{
    public class SizeMap : ClassMap<Size>
    {
        public SizeMap()
        {
            Table("Sizes");

            Id(a => a.Id);
            Map(a => a.Number);

            HasManyToMany(a => a.Products)
                .Cascade.SaveUpdate();
        }
    }
}
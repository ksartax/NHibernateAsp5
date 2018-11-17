using FluentNHibernate.Mapping;

namespace NHibernateExample.Models.NHibernateMap
{
    public class AdresMap : ClassMap<Adres>
    {
        public AdresMap()
        {
            Table("Address");

            Id(a => a.Id)
                .Column("Id")
                .GeneratedBy.Assigned()
                .CustomType<int>();

            Map(a => a.City)
                .Column("City")
                .CustomType<string>()
                .Nullable();

            HasOne(x => x.User)
                .Cascade.All();
        }
    }
}
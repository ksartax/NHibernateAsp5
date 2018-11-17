using FluentNHibernate.Mapping;

namespace NHibernateExample.Models.NHibernateMap
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Table("AppUser");

            Id(x => x.Id);

            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.EntityStatus).CustomType<EntityStatus>();

            HasOne(u => u.Adres);
            HasMany(a => a.Orders);
        }   
    }
}
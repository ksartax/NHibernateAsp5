using NHibernateExample.ViewModel;
using System.Collections.Generic;

namespace NHibernateExample.Models
{
    public class User
    {
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual EntityStatus EntityStatus { get; set; } = EntityStatus.ACTIVE;

        public virtual Adres Adres { get; set; }

        public virtual IList<Order> Orders { get; set; }

        public User()
        {
        }

        public User(UserCreateViewModel userCreateViewModel)
        {
            FirstName = userCreateViewModel.FirstName;
            LastName = userCreateViewModel.LastName;
            Adres = new Adres() {
                City = userCreateViewModel.City
            };
        }
    }

    public enum EntityStatus
    {
        ACTIVE,
        DELETE
    }
}
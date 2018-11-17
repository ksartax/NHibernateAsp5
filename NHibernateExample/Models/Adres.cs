namespace NHibernateExample.Models
{
    public class Adres
    {
        public virtual int Id { get; set; }

        public virtual string City { get; set; }

        public virtual User User { get; set; }
    }
}
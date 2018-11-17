using NHibernateExample.Models;
using System.ComponentModel.DataAnnotations;

namespace NHibernateExample.ViewModel
{
    public class UserViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Imie")]
        public string FirstName { get; set; }
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }
        [Display(Name = "Miasto")]
        public string City { get; set; }

        public UserViewModel()
        {
        }

        public UserViewModel(User user)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;

            City = user.Adres?.City;
        }
    }
}
using System.ComponentModel.DataAnnotations;

namespace NHibernateExample.ViewModel.SizeViewModel
{
    public class SizeCreateViewModel
    {
        [Required(ErrorMessage = "Pole wymagane")]
        [Display(Name = "Rozmiar")]
        public int Number { get; set; }
    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NHibernateExample.ViewModel.ProductViewModel
{
    public class ProductCreateViewModel
    {
        [Display(Name = "Nazwa")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Cena")]
        [Required]
        public float Price { get; set; }

        [Display(Name = "Rozmiary")]
        [Required]
        public List<int> SizesIdList { get; set; } = new List<int>();
    }
}
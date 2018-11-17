using NHibernateExample.Models;
using System.Collections.Generic;
using System.Linq;

namespace NHibernateExample.ViewModel.ProductViewModel
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        public SizeViewModel.SizesViewModel Sizes { get; set; }

        public ProductViewModel()
        {
        }

        public ProductViewModel(Product product)
        {
            Id = product.Id;
            Name = product.Name;
            Price = product.Price;

            Sizes = new SizeViewModel.SizesViewModel(product.Sizes.ToList());
        }
    }
}
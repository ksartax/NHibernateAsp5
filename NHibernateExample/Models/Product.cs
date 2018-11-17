using System.Collections.Generic;
using NHibernateExample.ViewModel.ProductViewModel;

namespace NHibernateExample.Models
{
    public class Product
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual float Price { get; set; }

        public virtual IList<Size> Sizes { get; set; } = new List<Size>();

        public Product(ProductCreateViewModel productCreateViewModel)
        {
            Name = productCreateViewModel.Name;
            Price = productCreateViewModel.Price;
        }

        public Product()
        {
        }
    }
}
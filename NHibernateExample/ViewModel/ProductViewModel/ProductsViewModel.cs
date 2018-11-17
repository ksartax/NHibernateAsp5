using NHibernateExample.Models;
using System.Collections.Generic;

namespace NHibernateExample.ViewModel.ProductViewModel
{
    public class ProductsViewModel : List<ProductViewModel>
    {
        public ProductsViewModel(List<Product> product) : base()
        {
            product.ForEach(s => Add(new ProductViewModel(s)));
        }
    }
}
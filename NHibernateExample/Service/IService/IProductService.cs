using NHibernateExample.Service.IService.Helper;
using NHibernateExample.ViewModel.ProductViewModel;

namespace NHibernateExample.Service.IService
{
    public interface IProductService : ISelectList
    {
        ProductsViewModel GetProductsViewModel();
        void Add(ProductCreateViewModel productCreateViewModel);
    }
}

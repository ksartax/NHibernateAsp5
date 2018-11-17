using NHibernateExample.Service.IService;
using NHibernateExample.Repository.IRepository;
using NHibernateExample.ViewModel.ProductViewModel;
using System.Web.Mvc;
using NHibernateExample.Repository.IRepository.Helper;
using NHibernateExample.Models;

namespace NHibernateExample.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IRepositoryBasicGet<Size> _sizeRepositoryBasicGet;

        public ProductService(IProductRepository productRepository, IRepositoryBasicGet<Size> sizeRepositoryBasicGet)
        {
            _productRepository = productRepository;
            _sizeRepositoryBasicGet = sizeRepositoryBasicGet;
        }

        public void Add(ProductCreateViewModel productCreateViewModel)
        {
            var product = new Product(productCreateViewModel);

            productCreateViewModel.SizesIdList.ForEach(id => {
                product.Sizes.Add(_sizeRepositoryBasicGet.GetById(id));
            });

            _productRepository.Save(product);
        }

        public ProductsViewModel GetProductsViewModel() 
            => new ProductsViewModel(_productRepository.GetListWithSizes());

        public SelectList GetSelectList()
            => new SelectList(_productRepository.GetList(), "Id", "Name");
    }
}
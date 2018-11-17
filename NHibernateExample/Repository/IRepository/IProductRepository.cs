using NHibernateExample.Models;
using NHibernateExample.Repository.IRepository.Helper;
using System.Collections.Generic;

namespace NHibernateExample.Repository.IRepository
{
    public interface IProductRepository : IRepositoryBasicGet<Product>, IRepositorySave<Product>, IRepositoryDelete<Product>
    {
        List<Product> GetListWithSizes();
    }
}

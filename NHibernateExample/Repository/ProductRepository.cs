using System.Collections.Generic;
using System.Linq;
using NHibernate.Linq;
using NHibernateExample.DbContext;
using NHibernateExample.Models;
using NHibernateExample.Repository.Helper;
using NHibernateExample.Repository.IRepository;

namespace NHibernateExample.Repository
{
    public class ProductRepository : RepositoryBasicAbstract<Product>, IProductRepository
    {
        public List<Product> GetListWithSizes()
        {
            using (var session = NHibernateHelper.OpenSession)
            {
                return session.Query<Product>()
                    .FetchMany(a => a.Sizes)
                    .ToList();
            }
        }
    }
}
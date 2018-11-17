using NHibernateExample.Models;
using NHibernateExample.Repository.IRepository.Helper;

namespace NHibernateExample.Repository.IRepository
{
    public interface IOrderRepository : IRepositoryBasicGet<Order>, IRepositorySave<Order>, IRepositoryDelete<Order>
    {
    }
}

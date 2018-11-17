using NHibernateExample.Models;
using NHibernateExample.Repository.IRepository.Helper;

namespace NHibernateExample.Repository.IRepository
{
    public interface ISizeRepository : IRepositoryBasicGet<Size>, IRepositorySave<Size>, IRepositoryDelete<Size>
    {
    }
}

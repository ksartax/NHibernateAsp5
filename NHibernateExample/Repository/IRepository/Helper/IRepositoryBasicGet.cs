using System.Collections.Generic;

namespace NHibernateExample.Repository.IRepository.Helper
{
    public interface IRepositoryBasicGet<T>
    {
        List<T> GetList();
        T GetById(int id);
    }
}

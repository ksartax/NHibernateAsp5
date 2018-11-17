namespace NHibernateExample.Repository.IRepository.Helper
{
    public interface IRepositoryDelete<T>
    {
        void Delete(T entity);
    }
}

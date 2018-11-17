namespace NHibernateExample.Repository.IRepository.Helper
{
    public interface IRepositorySave<T>
    {
        void Save(T entity);
    }
}

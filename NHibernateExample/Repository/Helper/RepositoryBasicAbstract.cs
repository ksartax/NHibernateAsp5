using NHibernateExample.DbContext;
using NHibernateExample.Repository.IRepository.Helper;
using System.Collections.Generic;
using System.Linq;

namespace NHibernateExample.Repository.Helper
{
    public abstract class RepositoryBasicAbstract<T> : IRepositoryBasicGet<T>, IRepositorySave<T>, IRepositoryDelete<T>
    {
        public virtual void Delete(T entity)
        {
            using (var session = NHibernateHelper.OpenSession)
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Delete(entity);
                }
            }
        }

        public virtual T GetById(int id)
        {
            using (var session = NHibernateHelper.OpenSession)
            {
                return session.Get<T>(id);
            }
        }

        public virtual List<T> GetList()
        {
            using (var session = NHibernateHelper.OpenSession)
            {
                return session.Query<T>().ToList();
            }
        }

        public virtual void Save(T entity)
        {
            using (var session = NHibernateHelper.OpenSession)
            {
                session.SaveOrUpdate(entity);
                session.Flush();
            }
        }
    }
}
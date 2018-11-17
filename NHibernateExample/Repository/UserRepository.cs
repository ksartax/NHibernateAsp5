using NHibernate;
using NHibernate.Linq;
using NHibernateExample.DbContext;
using NHibernateExample.Models;
using NHibernateExample.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace NHibernateExample.Repository
{
    public class UserRepository : IUserRepository
    {
        public List<User> GetUsersList(Expression<Func<User, bool>> whereExpression)
        {
            using (ISession session = NHibernateHelper.OpenSession)
            {
                if (whereExpression == null)
                {
                    return session.Query<User>()
                            .Fetch(a => a.Adres)
                            .ToList();
                }

                return session.Query<User>()
                         .Where(whereExpression)
                         .Fetch(a => a.Adres)
                         .FetchMany(a => a.Orders)
                         .ToList();
            }
        }

        public void Save(User user)
        {
            using (ISession session = NHibernateHelper.OpenSession)
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(user);
                }
            }
        }
    }
}
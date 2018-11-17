using NHibernateExample.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace NHibernateExample.Repository.IRepository
{
    public interface IUserRepository
    {
        List<User> GetUsersList(Expression<Func<User, bool>> whereExpression);
        void Save(User user);
    }
}

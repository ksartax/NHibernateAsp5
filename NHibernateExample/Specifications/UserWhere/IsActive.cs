using NHibernateExample.Models;
using System;
using System.Linq.Expressions;

namespace NHibernateExample.Specifications.UserWhere
{
    public class IsActive : Specification<User, bool>
    {
        public override Expression<Func<User, bool>> ToExpression() => user => user.EntityStatus == EntityStatus.ACTIVE;
    }
}
using NHibernateExample.Models;
using System;
using System.Linq.Expressions;

namespace NHibernateExample.Specifications.UserWhere
{
    public class LastNameLengthLimit : Specification<User, bool>
    {
        private readonly int _lengthLimit;

        public LastNameLengthLimit(int lengthLimit)
        {
            _lengthLimit = lengthLimit;
        }

        public override Expression<Func<User, bool>> ToExpression() => user => user.LastName.Length <= _lengthLimit;
    }
}
using System;
using System.Linq;
using System.Linq.Expressions;

namespace NHibernateExample.Specifications
{
    public sealed class NotSpecification<T, O> : Specification<T, O>
    {
        private readonly Specification<T, O> _specification;

        public NotSpecification(Specification<T, O> specification)
        {
            _specification = specification;
        }

        public override Expression<Func<T, O>> ToExpression()
        {
            Expression<Func<T, O>> expression = _specification.ToExpression();

            UnaryExpression notExpression = Expression.Not(expression.Body);

            return Expression.Lambda<Func<T, O>>(notExpression, expression.Parameters.Single());
        }
    }
}
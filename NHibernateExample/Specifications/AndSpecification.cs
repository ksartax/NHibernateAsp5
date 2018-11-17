using System;
using System.Linq;
using System.Linq.Expressions;

namespace NHibernateExample.Specifications
{
    public sealed class AndSpecification<T, O> : Specification<T, O>
    {
        private readonly Specification<T, O> _left;
        private readonly Specification<T, O> _right;

        public AndSpecification(Specification<T, O> left, Specification<T, O> right)
        {
            _left = left;
            _right = right;
        }

        public override Expression<Func<T, O>> ToExpression()
        {
            Expression<Func<T, O>> leftExpression = _left.ToExpression();
            Expression<Func<T, O>> rightExpression = _right.ToExpression();

            BinaryExpression binaryExpression = Expression.AndAlso(leftExpression.Body, rightExpression.Body);

            return Expression.Lambda<Func<T, O>>(binaryExpression, leftExpression.Parameters.Single());
        }
    }
}
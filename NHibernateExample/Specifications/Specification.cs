using System;
using System.Linq.Expressions;

namespace NHibernateExample.Specifications
{
    public abstract class Specification<T, O>
    {
        public abstract Expression<Func<T, O>> ToExpression();

        public Func<T, O> Func() => ToExpression().Compile();

        public Specification<T, O> And(Specification<T, O> specification) => new AndSpecification<T, O>(this, specification);
        public Specification<T, O> Else(Specification<T, O> specification) => new OrSpecification<T, O>(this, specification);
        public Specification<T, O> Not(Specification<T, O> specification) => new NotSpecification<T, O>(this);
    }
}
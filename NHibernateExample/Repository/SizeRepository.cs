using NHibernateExample.Models;
using NHibernateExample.Repository.Helper;
using NHibernateExample.Repository.IRepository;

namespace NHibernateExample.Repository
{
    public class SizeRepository : RepositoryBasicAbstract<Size>, ISizeRepository
    {
    }
}
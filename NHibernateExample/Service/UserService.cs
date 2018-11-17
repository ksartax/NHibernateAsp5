using NHibernateExample.Models;
using NHibernateExample.Repository.IRepository;
using NHibernateExample.Service.IService;
using NHibernateExample.Specifications.UserWhere;
using NHibernateExample.ViewModel;
using System.Linq;

namespace NHibernateExample.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository; 
        }

        public void Add(UserCreateViewModel userCreateViewModel)
        {
            _userRepository.Save(new User(userCreateViewModel));
        }

        public UsersViewModel GetUsersViewModel(string status = "ACTIVE")
        {
            if (status == nameof(EntityStatus.ACTIVE))
            {
                var expression = new IsActive()
                  //  .And(new LastNameLengthLimit(2))
                    .ToExpression();

                var users = _userRepository.GetUsersList(expression);

                return new UsersViewModel(users);
            }

            return new UsersViewModel(_userRepository.GetUsersList(new IsDeleted().ToExpression()));
        }

        public void JoinTest()
        {
            var users = _userRepository.GetUsersList(null);
            var userFirst = users.Last();

            userFirst.Adres = new Adres()
            {
                City = "KKKKKK"
            };

            _userRepository.Save(userFirst);
        }
    }
}
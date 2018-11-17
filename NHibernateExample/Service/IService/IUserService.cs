using NHibernateExample.ViewModel;

namespace NHibernateExample.Service.IService
{
    public interface IUserService
    {
        UsersViewModel GetUsersViewModel(string status = "ACTIVE");
        void Add(UserCreateViewModel userCreateViewModel);
        void JoinTest();
    }
}

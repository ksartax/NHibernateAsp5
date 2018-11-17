using NHibernateExample.Models;
using System.Collections.Generic;

namespace NHibernateExample.ViewModel
{
    public class UsersViewModel
    {
        public List<UserViewModel> Users { get; set; }

        public UsersViewModel()
        {
        }

        public UsersViewModel(List<User> users)
        {
            Users = new List<UserViewModel>();

            users.ForEach(u => Users.Add(new UserViewModel(u)));
        }
    }
}
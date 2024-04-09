using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using Welcome.Others;

namespace Welcome.ViewModel
{
    public class UserViewModel
    {
        public User _user;

      public UserViewModel(User user)
      {
          _user = user;
      }

        public UserViewModel(UserViewModel viewModel)
        {
        }

        public string Name 
        {
            get { return _user.Name;}
            set { _user.Name = value;}
        }
        public string Password
        {
            get { return _user.Password;}
            set { _user.Password = value;}
        }
        public UsersRolesEnum Roles
        {
            get { return _user.Roles;}
            set { _user.Roles = (Others.UsersRolesEnum)value;}
        }
        public void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Password: {Password}");
            Console.WriteLine($"Roles: {Roles}");
        }
        public void DisplayError()
        {
            throw new Exception("Текст на грешката");
        }
    }
}

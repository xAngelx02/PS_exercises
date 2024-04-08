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
        public User User { get; set; }

      public UserViewModel(User user)
      {
          _user = user;
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
    }
}

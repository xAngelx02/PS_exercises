using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Others;

namespace Welcome.Model
{
    public class User
    {
        public string name;
        private string password;
        public UsersRolesEnum roles;
        public int fNum;
        public string email;

        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public  UsersRolesEnum Roles
        {
            get { return roles; }
            set { roles = value; }
        }

        public int FNum
        {
            get { return fNum;}
            set { fNum = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}

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
        public string password;
        public UsersRolesEnum roles;
        public int fNum;
        public string email;
        public int Id;
        public DateTime Expires;

        public User(string name, string password, UsersRolesEnum roles, int fNum, string email, int Id, DateTime expires)
        {
            this.name = name;
            this.password = password;
            this.roles = roles;
            this.fNum = fNum;
            this.email = email;
            this.Id = Id;
            this.Expires = expires;
        }

        public User(string? name, string? password, UsersRolesEnum role)
        {
            this.name = name;
            this.password = password;
            Role = role;
        }

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

        public int id
        {
            get { return Id; }
            set { Id = value; }
        }

        public DateTime expires
        {
            get { return Expires; }
            set { Expires = value; }
        }

        public UsersRolesEnum Role { get; }
    }
}

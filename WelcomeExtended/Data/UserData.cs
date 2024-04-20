using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Welcome.Model;
using Welcome.Others;

namespace WelcomeExtended.Data
{
    public class UserData
    {
        private List<User> _users; 
        private int _nextId;
        private bool _isActive = false;

        public UserData()
        {
            _users = new List<User>();
            _nextId = 0;
        }
        
        public void AddUser(User user)
        {
            user.Id = _nextId++;
            _users.Add(user);
            _nextId++;
        }

         public User AddUser()
         {
             Console.WriteLine("Enter user Name");
             string name = Console.ReadLine();

             Console.WriteLine("Enter user Password");
             string password = Console.ReadLine();

             bool isValidRole;
             do
             {
                 Console.WriteLine("Enter user Role. \n\tADMIN, STUDENT, PROFESSOR, INSPECTOR, \n\t ");
                 string roles = Console.ReadLine();

                 isValidRole = Enum.TryParse<UsersRolesEnum>(roles.ToUpper(), out  var role);
                 if (isValidRole)
                 {
                     User user = new User(name, password, role);
                     user.Id = _nextId++;
                     _users.Add(user);
                     ++_nextId;

                     return _users.Last();
                 }
                 else
                     Console.WriteLine("Wrong user Role!\n");
             } while (!isValidRole);

             return _users.Last();
         }
        
        public void RemoveUser(User user)
        {
            _users.Remove(user);
        }
        public void RemoveUser()
        {
            Console.WriteLine("Enter user Name to remove\n");
            string name = Console.ReadLine();

            foreach (User user in _users)
            {
                if (user.Name == name)
                {
                    _users.Remove(user);
                    return;
                }
            }
        }
        public bool ValidateUser(string name, string password)
        {
            foreach (var user in _users)
            {
                if (user.Name == name && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }   
       public bool ValidateUserLambda(string name, string password)
        {
            return _users.Where(x => x.Name == name &&  x.Password == password).FirstOrDefault() != null ? true : false;
        }

        public bool ValidateUserLinq(string name, string password)
        {
            var ret = from user in _users
                       where user.Name == name && user.Password == password
                       select user.Id;
            return ret != null ? true : false;
        }

        public User GetUser(string name, string password)
        {
            foreach (var user in _users)
            {
                if (user.Name == name && user.Password == password)
                {
                    return user;
                }
            }
            return null;
        }

        public void AsssignUserRole(string name, UsersRolesEnum roles)
        {
            foreach (User user in _users)
            {
                if (user.Name == name)
                {
                    user.Roles = roles;
                    return;
                }

            }
        }

        public void SetActive(string name, string date)
        {
            DateTime temp;
            if (DateTime.TryParse(date, out temp)) 
            {
                foreach (User user in _users)
                {
                    if (user.Name == name)
                    {
                        user.Expires = temp;
                        return;                     
                    }

                }
            }
        }
    }

}

using System.Data;
using System.Xml.Linq;
using Welcome.Model;
using Welcome.Others;
using Welcome.ViewModel;
using WelcomeExtended.Data;
using WelcomeExtended.Helpers;

namespace WelcomeExtended
{
     class Program
    {
        static void Main(string[] args)
        {
                UserData userData = new UserData();

                var studentUser = new User("John", "123", UsersRolesEnum.STUDENT);
                userData.AddUser(studentUser);

                User studentUser2 = new User("George", "123", UsersRolesEnum.STUDENT);
                userData.AddUser(studentUser2);

                User TeacherUser = new User("Jane", "1234", UsersRolesEnum.PROFESSOR);
                userData.AddUser(TeacherUser);

                User AdminUser = new User("Jack", "12345", UsersRolesEnum.ADMIN); 
                userData.AddUser(AdminUser);

            Console.WriteLine("Enter user name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string pass = Console.ReadLine();

            try
            {
                if (UserHelper.ValidateCredentials(userData, name, pass))
                    Console.WriteLine(UserHelper.ToString(userData.GetUser(name, pass)));
                else
                    throw new Exception("User not found");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }    
    }
}

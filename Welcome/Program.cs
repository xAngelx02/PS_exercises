using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;

namespace Welcome
{
    public class Program
    {
        static void Main(string[] args)
        {
            User user = new User
            {
                Name = "Georgi",
                Password = "12345678",
                roles = Others.UsersRolesEnum.ADMIN,
                fNum = 121221151
            };
            User user1 = new User
            {
                Name = "Angel",
                Password = "88888888",
                roles = Others.UsersRolesEnum.PROFESSOR,
                fNum = 121221007
            };

            UserViewModel userViewModel = new UserViewModel(user);

            UserView userView = new UserView(userViewModel);
            
            userView.DisplayAttribute(user);
            userView.DisplayAttribute(user1);


            Console.ReadKey();
        }
    }
}

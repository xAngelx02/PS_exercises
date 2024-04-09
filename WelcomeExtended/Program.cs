using Welcome.Model;
using Welcome.ViewModel;

namespace WelcomeExtended
{
     class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var user = new User
                {
                    Name = "John Smith",
                    Password = "password123",
                    Roles = Welcome.Others.UsersRolesEnum.STUDENT
                };

                var viewModel = new UserViewModel(user);
                var view = new UserViewModel(viewModel);
                view.Display();
                view.DisplayError();

            }
            catch (Exception e)
            {
                var log = new ActionOnError(WelcomeExtended.Others.Delegates.Log);
                log(e.Message);
            }
            finally
            {
                Console.WriteLine("Execute in any case!");
            }

            var logger = new Loggers.HashLogger.FileLogger("C:\\Users\\Acho\\source\\repos\\PS_42_Angel\\WelcomeExtended");
        }
    }
}

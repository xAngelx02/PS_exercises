using DataLayer.Database;
using DataLayer.Model;
using Welcome.Others;

namespace DataLayer
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DatabaseContext())
            {                
                context.Database.EnsureCreated();
                context.Add<DataBaseUser>(new DataBaseUser()
                {
                    name = "user",
                    password = "1234",
                    Roles = UsersRolesEnum.STUDENT,
                    Expires = DateTime.Now
                });
                context.SaveChanges();
                var users = context.Users.ToList();
                Console.ReadKey();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using Welcome.ViewModel;


namespace Welcome.View
{
    public class UserView
    {
        public UserViewModel _viewModel;
        public UserView(UserViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public void DisplayAttribute(User user)
        {
            Console.WriteLine("Welcome" + "\n" + "Name: " + user.Name + "\n" + "Role: " + user.roles + "\n" + "Fnum: " + user.fNum + "\n");
        }
    }
}

using PS_Lab1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PS_Lab1.View
{
    public class UserView
    {
        private UserViewModel _viewModel;

        public UserView(UserViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public void Display()
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("User: " + _viewModel.Names);
            Console.WriteLine("User: " + _viewModel.Password);

        }

        public void DisplayError()
        {
            throw new Exception("Error");
        }    
        public void isValidEmail(string email)
        { 
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(email))
            {
                Console.WriteLine("Valid Email");
            }else Console.WriteLine("Invalid Email");
        }
    }
}

using PS_Lab1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WelcomeExtended.Data;

namespace WelcomeExtended.Helpers
{
    internal static class UserHelper
    {
        public static string ToString(this User user)
        {
            return $"User: {user.Names}, {user.Password}, {user.Role}";
        }

        public static void ValidateCredentials(this UserData userdata, string name, string password)
        {
            
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("The name cannot be null!");
            }
            else if (string.IsNullOrEmpty(password))
            {
                Console.WriteLine("The password cannot be null!");
            }

            bool isValid = userdata.ValidateUser(name, password);
            if (isValid)
            {
                Console.WriteLine("User is valid!");
            }
            else
            {
                Console.WriteLine("User is not valid!");
            }
        }

        public static void GetUser(this UserData userData, string username, string password)
        {
            var user = userData.GetUser(username, password);
            if (user != null)
            {
                user.ToString();
            }
        }

    }
}

using PS_Lab1.Model;
using PS_Lab1.View;
using PS_Lab1.ViewModel;

namespace PS_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            user1.Names = "User1";
            user1.Password = "password";
            user1.Role = Others.UserRolesEnum.ADMIN;
            string email1 = user1.Email = "user1@gmail.com";

            User user2 = new User();
            user2.Names = "User2";
            user2.Password = "password";
            user2.Role = Others.UserRolesEnum.ANONYMOUS;
            string email2 = user2.Email = "user2@gmail.com";

            UserViewModel userViewModel1 = new UserViewModel(user1);
            UserView userView1 = new UserView(userViewModel1);

            userView1.Display();
            userView1.isValidEmail(email1);


            //Console.WriteLine("Encrypted password is: " + user2.ToString());
        }
    }
}

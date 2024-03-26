using Microsoft.Extensions.Logging;
using PS_Lab1.Model;
using PS_Lab1.Others;
using PS_Lab1.View;
using PS_Lab1.ViewModel;
using WelcomeExtended.Data;
using WelcomeExtended.Helpers;
using WelcomeExtended.Loggers;
using static WelcomeExtended.Others.Delegates;

namespace WelcomeExtended
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////User u = new User(66, "John Smith");
            //try {
            //    //{   var fileLogger = new FileLogger("C://Users//sokol//Desktop//skola//C#//PS_Lab1");
            //    var user = new User
            //    {
            //        Names = "John Smith",
            //        Password = "password123",
            //        Role = UserRolesEnum.STUDENT
            //    };

            //    var viewModel = new UserViewModel(user);
            //    var view = new UserView(viewModel);
            //    view.Display();
            //    view.DisplayError();

            //    //fileLogger.LogInformation("User created successfully!");
            //}
            //catch (Exception e)
            //{
            //    var log = new ActionOnError(Log);
            //    log(e.Message);

                
            //}
            //finally
            //{
            //    Console.WriteLine("Executed in any case!");
            //}

            UserData userData = new UserData();
            User studentUser = new User()
            {
                Names = "John Smith",
                Password = "password123",
                Role = UserRolesEnum.STUDENT
            };

            userData.AddUser(studentUser);

            userData.ValidateCredentials("John Smith", "password12");

        }
    }
}

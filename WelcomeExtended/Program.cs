using PS_Lab1.Model;
using PS_Lab1.Others;
using PS_Lab1.View;
using PS_Lab1.ViewModel;
using static WelcomeExtended.Others.Delegates;

namespace WelcomeExtended
{
    public class Program
    {
        static void Main(string[] args)
        {
            //User u = new User(66, "John Smith");
            try
            {
                var user = new User
                {
                    Names = "John Smith",
                    Password = "password123",
                    Role = UserRolesEnum.STUDENT
                };

                var viewModel = new UserViewModel(user);
                var view = new UserView(viewModel);
                view.Display();
                view.DisplayError();
            }
            catch (Exception e)
            {
                var log = new ActionOnError(Log);
                log(e.Message);
            }
            finally
            {
                Console.WriteLine("Executed in any case!");
            }
        }
    }
}

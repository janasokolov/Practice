using DataLayer.Database;
using DataLayer.Model;
using PS_Lab1.Model;
using PS_Lab1.Others;
using System.Xml.Linq;

namespace DataLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DatabaseContext())
            {
                context.Database.EnsureCreated();
                context.Add<DatabaseUser>(new DatabaseUser(){
                    Names = "user",
                    Password = "password",
                    Expires = DateTime.Now,
                    Email = "user@mail.com",
                    Role = UserRolesEnum.STUDENT
                });
                context.SaveChanges();
                var users = context.Users.ToList();

                var ret = from user in context.Users
                          where user.Names == "user" && user.Password == "password"
                          select user.Id;
                if (ret!=null)
                {
                    Console.WriteLine("User found");
                    
                }
                else
                {
                    Console.WriteLine("User not found");
                }

                Console.ReadKey();


            }
        }

    }
}

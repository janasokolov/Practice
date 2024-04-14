using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using PS_Lab1.Others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Database
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string solutionFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFile = "Welcome.db";
            string databasePath = Path.Combine(solutionFolder, databaseFile);
            optionsBuilder.UseSqlite($"Data Source={databasePath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DatabaseUser>().Property(e => e.Id).ValueGeneratedOnAdd();

            var user = new DatabaseUser()
            {
                Id = 1,
                Names = "John Doe",
                Password = "1234",
                Role = UserRolesEnum.ADMIN,
                Email = "johndoe@mail.com",
                Expires = DateTime.Now.AddYears(10)
            };

            var user2 = new DatabaseUser()
            {
                Id = 2,
                Names = "Maria Silver",
                Password = "aa12",
                Role = UserRolesEnum.STUDENT,
                Email = "maria@mail.com",
                Expires = DateTime.Now.AddYears(10)
            };

            var user3 = new DatabaseUser()
            {
                Id = 3,
                Names = "Liam P",
                Password = "liam12",
                Role = UserRolesEnum.STUDENT,
                Email = "liamp@mail.com",
                Expires = DateTime.Now.AddYears(10)
            };

            modelBuilder.Entity<DatabaseUser>()
                .HasData(user, user2, user3);

        }

        public DbSet<DatabaseUser> Users { get; set; }
       
    }
}

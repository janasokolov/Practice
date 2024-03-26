using PS_Lab1.Model;
using PS_Lab1.Others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WelcomeExtended.Data
{
    internal class UserData
    {
        private List<User> _users;
        private int _nextId;
        

        public UserData()
        {
            _users = new List<User>();
            _nextId = 0;
        }

        //public UserData()
        //{
        //}

        public void AddUser(User user)
        {
            user.Id = _nextId++;
            _users.Add(user);
        }

        public void RemoveUser(User user)
        {
            _users.Remove(user);
        }

        public bool ValidateUser(string name, string password)
        {
            foreach (var user in _users)
            {
                if (user.Names == name && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidateUserLambda(string name, string password)
        {
            return _users.Where(x => x.Names == name && x.Password == password)
                .FirstOrDefault() != null ? true : false;
        }

        public bool ValidateUserLinq(string name, string password)
        {
            var ret = from user in _users
                        where user.Names == name && user.Password == password
                        select user.Id;
            return ret != null ? true : false;
        }

        public User GetUser(string name, string password)
        {   
            //return (User)_users.Where(u => u.Names == name && u.Password == password);
            var ret = from user in _users
                      where user.Names == name && user.Password == password
                      select user.Id;
            return (User)ret;
        }

        public void SetActive(string username, DateTime expirationDate)
        {
            var ret = from user in _users
                       where user.Names == username
                       select user.Id;
            var ret2 = (User)ret;
            if (ret != null)
            {
                ret2.Expires = expirationDate;
            }
        }

        public void AssignUserRole(string username, UserRolesEnum role)
        {
            var ret = from user in _users
                      where user.Names == username
                      select user.Id;
            var ret2 = (User)ret;
            if (ret != null)
            {
                ret2.Role = role;
            }
        }

    }
}

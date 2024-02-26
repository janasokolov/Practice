using PS_Lab1.Model;
using PS_Lab1.Others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_Lab1.ViewModel
{
    public class UserViewModel
    {
        private User _user;

        public UserViewModel(User user)
        {
            _user = user;
        }

        public string Names
        {
            get { return _user.Names; }
            set { _user.Names = value; }
        }

        public string Password
        {
            get { return _user.Password; }
            set { _user.Password = value; }
        }

        public UserRolesEnum Role
        {
            get { return _user.Role; }
            set { _user.Role = value; }
        }

        public int FacNum
        {
            get { return _user.FacNum; }
            set { _user.FacNum = value; }
        }

        public string Email
        {
            get { return _user.Email; }
            set { _user.Email = value; }
        }
    }
}

using PS_Lab1.Others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_Lab1.Model
{
    public class User
    {
        private string _names;
        private string _password;
        private int _facNum;
        private string _email;
        private int _id;
        private DateTime _expires;

        //public User(string names, string password, int facNum, string email, UserRolesEnum role, int id, DateTime expires)
        //{
        //    _names = names;
        //    _password = password;
        //    _facNum = facNum;
        //    _email = email;
        //    Role = role;
        //    _id = id;
        //    _expires = expires;
        //}

        //public User()
        //{
        //}

        public string Names { 
            get { return _names; }
            set { _names = value; } 
        }
        public string Password
        {
            get { return ConvertToDecrypt(_password); }
            set { _password = ConvertToEncrypt(value); }
        }

        public int FacNum
        {
            get { return _facNum; }
            set { _facNum = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public virtual int Id
        {
            get { return _id; }
            set { _id = value; }

        }
        
        public DateTime Expires
        {
            get { return _expires; }
            set { _expires = value; }
        }

        public UserRolesEnum Role { get; set; }

        public static string key = "janchy";
        public static string ConvertToEncrypt(string password)
        {
            if (string.IsNullOrEmpty(password)) return "";
            password += key;
            var passwordBytes = Encoding.UTF8.GetBytes(password);
            return Convert.ToBase64String(passwordBytes);
        }
        public override string ToString()
        {
            return _password;
        }
        public static string ConvertToDecrypt(string password)
        {
            if (string.IsNullOrEmpty(password)) return "";
            var passwordBytes = Convert.FromBase64String(password);
            password = Encoding.UTF8.GetString(passwordBytes);
            password = password.Substring(0, password.Length - key.Length);
            return password;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeController
{
    public class User
    {
        private int userId;
        private string userName;
        private string password;
        private string contactInfo;
        private bool isLoggedIn;
        public int UserId { 
            get { return userId; } 
            set { userId = value; } }

        public string UserName { 
            get { return userName; } 
            set { userName = value; } }

        public string ContactInfo { 
            get { return contactInfo; } 
            set {  contactInfo = value; } }

        public string Password
        {
            get { return password; }
            set { password = value; } }
        public bool IsLoggedIn
        {
            get { return isLoggedIn; }
            set { isLoggedIn = value; }
        }

        public bool Login(string userName, string password)
        {
            if (UserName == userName && Password == password) {
                IsLoggedIn = true;
                Console.WriteLine("Login Successful, Welcome" + userName);

            }
            else
            {
                IsLoggedIn = false;
                Console.WriteLine("Login failed, try again");
            }
            return IsLoggedIn;
        }
    }

}

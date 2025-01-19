using System;

namespace Authorization
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public bool IsSignIn { get; set; }
        public bool LastSignIn { get; set; }

        //public User(string inputLogin, string inputPassword)
        //{
        //    Login = inputLogin;
        //    Password = inputPassword;
        //    //IsSignIn = isSignIn;
        //}


    }
}
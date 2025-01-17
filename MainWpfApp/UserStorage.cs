using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authorization
{
    public class UserStorage
    {
        public const string fileName = "Users.json";
        public User GetSignInUser()
        {
            var users = GetAllUsers();
            return users.FirstOrDefault(x => x.IsSignIn);
        }

        private static List<User> GetAllUsers()
        {
            return FileProvider.Load<List<User>>(fileName) ?? new List<User>();
        }

        public void Add(User user)
        {
            //var users = new List<User>();
            var users = GetAllUsers();
            users.Add(user);
            FileProvider.Save(users, fileName);
        }

        public void SignOut()
        {
            var signInUser = GetSignInUser();
            if (signInUser != null)
            {
                var users = GetAllUsers();
                var existingUser = users.FirstOrDefault(x => x.Login ==  signInUser.Login && x.Password == signInUser.Password);
                existingUser.IsSignIn = false;
                FileProvider.Save(users, fileName);
            }
        }
    }
}

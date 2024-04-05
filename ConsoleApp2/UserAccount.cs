using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC3_1N_HMS
{
    public class UserAccount
    {
        public string Id { get; set; }
        public string Password { get; set; }
        public User User { get; set; }

        public UserAccount(string id, string password, User user)
        {
            Id = id;
            Password = password;
            User = user;
        }
    }
}

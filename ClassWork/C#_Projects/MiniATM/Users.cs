using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniATM
{
        public class User
        {
            public string Username { get; set; }
            public string Pin { get; set; }

            public BankAccount Account { get; set; }

            public User(string username, string pin, double balance)
            {
                Username = username;
                Pin = pin;
                Account = new BankAccount(balance);
            }
        }
    
}

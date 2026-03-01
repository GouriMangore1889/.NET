using MiniATM.MiniATM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniATM
{
        public class ATMService
        {
            private User _user;

            public ATMService(User user)
            {
                _user = user;
            }

            public bool Authenticate(string username, string pin)
            {
                return _user.Username == username && _user.Pin == pin;
            }

            public async Task Deposit(double amount)
            {
                _user.Account.Deposit(amount);
                await Logger.Log($"Deposited {amount}");
            }

            public async Task Withdraw(double amount)
            {
                _user.Account.Withdraw(amount);
                await Logger.Log($"Withdrew {amount}");
            }

            public double CheckBalance()
            {
                return _user.Account.Balance;
            }
        }
    }

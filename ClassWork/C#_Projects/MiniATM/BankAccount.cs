using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniATM
{
        public class BankAccount
        {
            public double Balance { get; private set; }

            public BankAccount(double initialBalance)
            {
                Balance = initialBalance;
            }

            public void Deposit(double amount)
            {
                if (amount <= 0)
                    throw new Exception("Invalid deposit amount.");

                Balance += amount;
            }

            public void Withdraw(double amount)
            {
                if (amount <= 0)
                    throw new Exception("Invalid withdraw amount.");

                if (amount > Balance)
                    throw new Exception("Insufficient balance.");

                Balance -= amount;
            }
        }
    }


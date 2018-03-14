using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Account
    {
        //FIELDS
        private string id;
        private string name;
        private int balance;

        //PROPERTIES
        public string Id
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
        }
        public int Balance
        {
            get { return balance; }
        }

        //CONSTRUCTORS
        public Account(string id, string name)
        {
            this.id = id;
            this.name = name;
            this.balance = 0;
        }
        public Account(string id, string name, int balance)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
        }

        //METHODS
        public int Credit(int amount)
        {
            balance += amount;
            return balance;
        }
        public int Debit(int amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Error: Account balance is lower than 'amount'.");
            }
            return balance;
        }
        public int TransferTo(Account another, int amount)
        {
            if (balance > this.Debit(amount))
            {
                another.Credit(amount);
            }
            return balance;
        }
        public override string ToString()
        {
            return $"Account[Name: {name}, Balance: {balance}]";
        }
    }
}

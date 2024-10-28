using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treashure
{
    public class People
    {
        public int ID { get; set; }
        public string Name { get; set; }

        // Constructor
        public People(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
    public class User : People
    {
        public float Balance { get; set; }
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();

        // Constructor with body
        public User(int id, string name, float balance) : base(id, name)
        {
            Balance = balance;
        }

        public float CheckBalance()
        {
            return Balance;
        }

        public List<Transaction> CheckHistory()
        {
            return Transactions;
        }

        public void AddTransaction(Transaction transaction)
        {
            Transactions.Add(transaction);
        }
    }
    public class Admin : People
    {
        public bool Permission { get; set; }

        public Admin(int id, string name, bool permission) : base(id, name)
        {
            Permission = permission;
        }

        public void ManageUserHistory(User user)
        {
            // Logic to manage user's history
            foreach (var transaction in user.CheckHistory())
            {
                // Display or process the user's transaction history
            }
        }

        public void ManageATM(PlasticATM atm, string newStatus)
        {
            atm.UpdateStatus(newStatus);
        }

        public void ManageTrashData(Plastic trash)
        {
            // Logic to manage plastic data
        }
    }
}

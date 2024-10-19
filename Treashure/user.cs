using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Treashure
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public float Balance { get; set; }
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();

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

}
